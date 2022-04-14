using CustomerUI.Model;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerUI.DBService.CommonService;

namespace CustomerUI.UI.Common
{
    public partial class FrmFunctionItem : FormDialog
    {
        public FrmFunctionItem(AuthoritiesService authorityService,
            FunctionItemService functionItemService,
            UserService userService,
            AppHost appHost)
        {
            InitializeComponent();

            this.authorityService = authorityService;
            this.functionItemService = functionItemService;
            this.userService = userService;
            this.appHost = appHost;
        }
        private readonly AppHost appHost;
        private readonly AuthoritiesService authorityService;
        private readonly FunctionItemService functionItemService;
        private readonly UserService userService;

        private bool isAdd;
        private Authorities authority;
        private Action action;
        private void FrmFunctionItem_Load(object sender, EventArgs e)
        {
            InitialUI();
        }

        private void InitialUI()
        {
            editLookupPanel1.labelControl1.Text = "选择用户";
            var users = userService.Query(null).Select(x=> new { UserId = x.UserId}).ToList();
            editLookupPanel1.lookUpEdit1.Properties.DataSource = users;
            editLookupPanel1.lookUpEdit1.Properties.DisplayMember = "UserId";
            editLookupPanel1.lookUpEdit1.Properties.ValueMember = "UserId";
            editLookupPanel1.lookUpEdit1.ItemIndex = -1;
            editLookupPanel1.lookUpEdit1.EditValueChanged += LookUpEdit1_EditValueChanged;
            treeMenuItems.CheckBoxes = true;
            QueryData();
        }
        /// <summary>
        /// 用户变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as LookUpEdit;
            var editValue = lookUp.EditValue?.ToString();
            if (string.IsNullOrEmpty(editValue))
            {
                ShowMsg("没有用户信息");
                return;
            }
            treeMenuItems.Nodes.Clear();
            var menuItems = functionItemService.GetFunctionItems();
            var firstLayer = new List<FunctionItem>();
            
            var authories = authorityService.GetAuthorityItemIds(editValue);
            Parallel.ForEach(menuItems, x => { if (authories.Contains(x.ItemId)) { x.IsChecked = true; } });
            firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
            foreach (var f in firstLayer)
            {
                CreateNode(f, menuItems.ToList());
            }
            BindingToTreeView(firstLayer);
            treeMenuItems.Show();
        }

        private void QueryData()
        {
            var menuItems = functionItemService.GetFunctionItems();
            var firstLayer = new List<FunctionItem>();
            if (isAdd)
            {
                firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
                foreach (var f in firstLayer)
                {
                    CreateNode(f, menuItems.ToList());
                }
            }
            else
            {
                editLookupPanel1.lookUpEdit1.EditValue = authority.USER_ID;
                editLookupPanel1.lookUpEdit1.ReadOnly = true;
                var authories = authorityService.GetAuthorityItemIds(authority.USER_ID);
                Parallel.ForEach(menuItems, x => { if (authories.Contains(x.ItemId)) { x.IsChecked = true; } });
                firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
                foreach (var f in firstLayer)
                {
                    CreateNode(f, menuItems.ToList());
                }
            }

            BindingToTreeView(firstLayer);
            treeMenuItems.Show();
        }


        private void BindingToTreeView(IList<FunctionItem> nodes)
        {
            foreach (var n in nodes)
            {
                TreeNode node = new TreeNode();
                node.Text = n.ItemName;
                node.Name = n.ItemId;
                node.Checked = n.IsChecked;
                CreateChildrenNode(node, n);
                treeMenuItems.Nodes.Add(node);
            }

        }

        private void CreateChildrenNode(TreeNode node, FunctionItem item)
        {
            var items = item.Children;
            if (items != null && items.Count != 0)
            {
                foreach (var i in items)
                {
                    TreeNode tmp = new TreeNode();
                    tmp.Text = i.ItemName;
                    tmp.Name = i.ItemId;
                    tmp.Checked = i.IsChecked;
                    CreateChildrenNode(tmp, i);
                    node.Nodes.Add(tmp);
                    if (tmp.Checked)
                        node.Checked = true;
                }
            }
        }

        private void CreateNode(FunctionItem item, IList<FunctionItem> menuItems)
        {
            var tmp = menuItems.Where(x => x.OrderNo == (item.OrderNo + 1) && x.ParentId == item.ItemId).ToList();
            if (tmp != null && tmp.Count != 0)
            {
                foreach (var i in tmp)
                {
                    CreateNode(i, menuItems);
                }
                ((List<FunctionItem>)item.Children).AddRange(tmp);
            }
        }

        /// <summary>
        /// 用户选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeMenuItems_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                var node = e.Node;
                var state = false;
                if (node.Checked)
                {
                    state = true;
                    SetChildNodeState(node, state);
                    SetParentNodeState(node, state);
                }
                else
                {
                    state = false;
                    SetChildNodeState(node, state);
                    SetParentNodeState(node, state);
                }
            }
        }

        private void SetChildNodeState(TreeNode node, bool state)
        {
            if (!state)
            {
                var nodes = node.Nodes;
                if (nodes.Count > 0)
                {
                    foreach (TreeNode n in nodes)
                    {
                        n.Checked = state;
                        SetChildNodeState(n, state);
                    }
                }
            }
        }

        private void SetParentNodeState(TreeNode node, bool state)
        {
            if (state)
            {
                var parent = node.Parent;
                if (parent != null)
                {
                    parent.Checked = state;
                    SetParentNodeState(parent, state);
                }
            }
        }
        /// <summary>
        /// 提交用户权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var userId = editLookupPanel1.lookUpEdit1.EditValue?.ToString();
            if (string.IsNullOrEmpty(userId))
            {
                ShowMsg("请选择授权用户");
                return;
            }

            var user = userService.GetUserByUserId(new User { UserId = userId });
            var nodes = treeMenuItems.Nodes;
            IList<TreeNode> selectedNodes = new List<TreeNode>();
            foreach (TreeNode node in treeMenuItems.Nodes)
            {
                if (node.Checked)
                {
                    selectedNodes.Add(node);
                }
                GetSelectedNodes(selectedNodes, node);
            }

            if (selectedNodes.Count != 0)
            {
                var menuItems = functionItemService.GetFunctionItems();
                var menuItemIds = selectedNodes.Select(x => x.Name).ToList();
                menuItems = menuItems.Where(x => menuItemIds.Contains(x.ItemId)).ToList();
                authorityService.DeleteAuthorityByUserId(user.UserId);
                foreach (var m in menuItems)
                {
                    var authority = new Authorities
                    {
                        USER_ID = user.UserId,
                        USER_NAME = user.UserName,
                        ITEM_ID = m.ItemId,
                        ITEM_NAME = m.ItemName,
                        ITEM_TYPE = m.ItemType,
                        DESCRIPTION = m.Description
                    };
                    authorityService.AddAuthority(authority);
                }
            }
            else
            {
                authorityService.DeleteAuthorityByUserId(user.UserId);
            }
            ShowMsg("提交成功");
            appHost.GetCurrentUserAuthorities();
            action?.Invoke();
        }

        private void GetSelectedNodes(IList<TreeNode> nodes, TreeNode node)
        {
            var childNodes = node.Nodes;
            if (childNodes.Count > 0)
            {
                foreach (TreeNode n in childNodes)
                {
                    if (n.Checked)
                    {
                        nodes.Add(n);
                    }
                    GetSelectedNodes(nodes, n);
                }
            }
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            authority = (Authorities)content;

            ShowDialog();
        }
    }
}
