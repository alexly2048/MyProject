using ConstructionManagement.Model;
using ConstructionManagement.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagement.UI
{
    public partial class FrmMenuItem : example
    {
        public FrmMenuItem()
        {
            InitializeComponent();
            
        }

        public bool IsAdd { get; set; }
        public Authority Authority { get; set; }
        private MenuItemService menuItemService = new MenuItemService();
        private AuthorityService authorityService = new AuthorityService();
        private LoginService loginService = new LoginService();
        public delegate void EditMenuItemRefresh();
        public event EditMenuItemRefresh Callback;
        private void FrmMenuItem_Load(object sender, EventArgs e)
        {
            try
            {
                var users = loginService.GetLoginUsers();
                cbUsers.DataSource = users;
                cbUsers.DisplayMember = "UserId";
                cbUsers.ValueMember = "UserId";
                cbUsers.SelectedIndex = -1;
                treeMenuItems.CheckBoxes = true;

                QueryData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void QueryData()
        {
            treeMenuItems.Nodes.Clear();
            var menuItems = menuItemService.GetMenuItems();
            var firstLayer = new List<NodeItem>();
            if (IsAdd)
            {
                 firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
                foreach(var f in firstLayer)
                {
                    CreateNode(f, menuItems);
                }
            }
            else
            {
                cbUsers.SelectedValue = Authority.UserId;
                cbUsers.Enabled = false;
                var authories = authorityService.GetAuthorityItemIds(Authority.UserId);
                Parallel.ForEach(menuItems, x => { if (authories.Contains(x.ItemId)) { x.IsChecked = true; } });
                firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
                foreach (var f in firstLayer)
                {
                    CreateNode(f, menuItems);
                }
            }
            BindingToTreeView(firstLayer);
            treeMenuItems.Show();
        }

        private void BindingToTreeView(IList<NodeItem> nodes)
        {
            foreach(var n in nodes)
            {
                TreeNode node = new TreeNode();
                node.Text = n.ItemName;
                node.Name = n.ItemId;
                node.Checked = n.IsChecked;
                CreateChildrenNode(node, n);
                treeMenuItems.Nodes.Add(node);
            }

        }

        private void CreateChildrenNode(TreeNode node,NodeItem item)
        {
            var items = item.Children;
            if(items != null && items.Count != 0)
            {
                foreach(var i in items)
                {
                    TreeNode tmp = new TreeNode();
                    tmp.Text = i.ItemName;
                    tmp.Name = i.ItemId;
                    tmp.Checked = i.IsChecked;
                    CreateChildrenNode(tmp, i);
                    node.Nodes.Add(tmp);
                    if (tmp.Checked)
                        node.Checked = true ;
                }
            }
        }

        private void CreateNode(NodeItem item,IList<NodeItem> menuItems)
        {
            var tmp = menuItems.Where(x => x.OrderNo == (item.OrderNo + 1) && x.ParentId == item.ItemId).ToList();
            if(tmp != null && tmp.Count != 0)
            {                
                foreach(var i in tmp)
                {
                    CreateNode(i, menuItems);
                }
                ((List<NodeItem>)item.Children).AddRange(tmp);
            }           
        }

        /// <summary>
        /// 用户选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeMenuItems_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if(e.Action == TreeViewAction.ByMouse)
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

        private void SetChildNodeState(TreeNode node,bool state)
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

        private void SetParentNodeState(TreeNode node,bool state)
        {
            if (state)
            {
                var parent = node.Parent;
                if(parent != null)
                {
                    parent.Checked = state;
                    SetParentNodeState(parent, state);
                }
            }
        }

        /// <summary>
        /// 提交权限设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = cbUsers.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(userId))
                {
                    ShowMsg("请选择授权用户");
                    return;
                }

                var user = new LoginUser();
                user = loginService.GetLoginUsers(userId).FirstOrDefault();
                var nodes = treeMenuItems.Nodes;
                IList<TreeNode> selectedNodes = new List<TreeNode>();
                foreach(TreeNode node in treeMenuItems.Nodes)
                {
                    if (node.Checked)
                    {
                        selectedNodes.Add(node);
                    }
                    GetSelectedNodes(selectedNodes, node);
                }

                if(selectedNodes.Count != 0)
                {
                    var menuItems = menuItemService.GetMenuItems();
                    var menuItemIds = selectedNodes.Select(x => x.Name).ToList();
                    menuItems = menuItems.Where(x => menuItemIds.Contains(x.ItemId)).ToList();
                    authorityService.DeleteAuthorityByUserId(user.UserId);
                    foreach(var m in menuItems)
                    {
                        var authority = new Authority
                        {
                            UserId = user.UserId,
                            UserName = user.UserName,
                            ItemId = m.ItemId,
                            ItemName = m.ItemName,
                            Description = m.Description
                        };
                        authorityService.AddAuthority(authority);
                    }
                }
                else
                {
                    authorityService.DeleteAuthorityByUserId(user.UserId);
                }
                ShowMsg("提交成功");
                Close();
                Callback?.Invoke();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void GetSelectedNodes(IList<TreeNode> nodes,TreeNode node)
        {
            var childNodes = node.Nodes;
            if(childNodes.Count > 0)
            {
                foreach(TreeNode n in childNodes)
                {
                    if (n.Checked)
                    {
                        nodes.Add(n);
                    }
                    GetSelectedNodes(nodes, n);
                }
            }
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbUsers.SelectedIndex;
            if (index < 0) return;
            var userId = (cbUsers.SelectedItem as LoginUser)?.UserId?.ToString();
            if (string.IsNullOrEmpty(userId)) return;
            treeMenuItems.Nodes.Clear();
            var menuItems = menuItemService.GetMenuItems();
            var firstLayer = new List<NodeItem>();
            var authories = authorityService.GetAuthorityItemIds(userId);
            Parallel.ForEach(menuItems, x => { if (authories.Contains(x.ItemId)) { x.IsChecked = true; } });
            firstLayer = menuItems.Where(x => x.OrderNo == 1).ToList();
            foreach (var f in firstLayer)
            {
                CreateNode(f, menuItems.ToList());
            }
            BindingToTreeView(firstLayer);
            treeMenuItems.Show();
        }
    }
}
