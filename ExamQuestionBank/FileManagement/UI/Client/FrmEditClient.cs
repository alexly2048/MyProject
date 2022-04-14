using DevExpress.XtraEditors.DXErrorProvider;
using FileManagement.Model;
using FileManagement.Service.DataService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FileManagement.UI
{
    public partial class FrmEditClient : FormDialog
    {
        public FrmEditClient(ClientService clientService, ProjectContractService contractService)
        {
            InitializeComponent();
            this.clientService = clientService;
            this.contractService = contractService;
        }
        private readonly ClientService clientService;
        private readonly ProjectContractService contractService;
        private bool isAdd = false;
        private Client client = new Client();
        private Action action;
        private IEnumerable<ProjectContract> contracts;
        private void FrmEditClient_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialValidation();
        }

        private void InitialUI()
        {
            editComboxPanel1.labelControl1.Text = "工程编号";
            editPanel1.labelControl1.Text = "工程名称";
            editDateTimePickerPanel1.labelControl1.Text = "报装资料";
            editDateTimePickerPanel2.labelControl1.Text = "停电";
            editDateTimePickerPanel3.labelControl1.Text = "增资";
            editDateTimePickerPanel4.labelControl1.Text = "退料";

            contracts = contractService.GetProjectContracts();
            foreach(var c in contracts)
            {
                editComboxPanel1.comboBoxEdit1.Properties.Items.Add(c.PROJECT_NUMBER.ToString());
            }
            editComboxPanel1.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            editComboxPanel1.comboBoxEdit1.SelectedIndexChanged += ComboBoxEdit1_SelectedIndexChanged;
            editPanel1.textEdit1.ReadOnly = true;
            
            if (!isAdd)
            {
             //   editComboxPanel1.comboBoxEdit1.Text = client.PROJECT_NUMBER;
                editComboxPanel1.comboBoxEdit1.SelectedItem = client.PROJECT_NUMBER;
                editPanel1.textEdit1.Text = client.PROJECT_NAME;
                editDateTimePickerPanel1.dateEdit1.Text = client.INSTALLATION_MATERIAL;
                editDateTimePickerPanel2.dateEdit1.Text = client.POWER_CUT;
                editDateTimePickerPanel3.dateEdit1.Text = client.ADD_MATERIAL;
                editDateTimePickerPanel4.dateEdit1.Text = client.RETURN_MATERIAL;
            }
        }

        private void InitialValidation()
        {
            ConditionValidationRule emptyRule = new ConditionValidationRule();
            emptyRule.ConditionOperator = ConditionOperator.IsNotBlank;
            emptyRule.ErrorText = "值不能为空";

            dxValidationProvider1.SetValidationRule(editComboxPanel1.comboBoxEdit1, emptyRule);
            dxValidationProvider1.SetValidationRule(editDateTimePickerPanel1.dateEdit1, emptyRule);
            dxValidationProvider1.SetValidationRule(editDateTimePickerPanel2.dateEdit1, emptyRule);
            dxValidationProvider1.SetValidationRule(editDateTimePickerPanel3.dateEdit1, emptyRule);
            dxValidationProvider1.SetValidationRule(editDateTimePickerPanel4.dateEdit1, emptyRule);
        }

        private void ComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var num = editComboxPanel1.comboBoxEdit1.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(num))
                return;
            editPanel1.textEdit1.Text = contracts.FirstOrDefault(x => x.PROJECT_NUMBER == num)?.PROJECT_NAME ?? string.Empty;
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            base.Shower(action, isAdd, content);
            this.isAdd = isAdd;
            this.action = action;
            if (!isAdd)
            {
                this.client = (Client)content;
            }
            ShowDialog();
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;

            client.PROJECT_NUMBER = editComboxPanel1.comboBoxEdit1.Text ;
            client.PROJECT_NAME = editPanel1.textEdit1.Text ;
            client.INSTALLATION_MATERIAL = editDateTimePickerPanel1.dateEdit1.Text;
            client.POWER_CUT = editDateTimePickerPanel2.dateEdit1.Text;
            client.ADD_MATERIAL = editDateTimePickerPanel3.dateEdit1.Text;
            client.RETURN_MATERIAL = editDateTimePickerPanel4.dateEdit1.Text;

            if (isAdd)
            {
                clientService.AddClient(client);
            }
            else
            {
                clientService.UpdateClient(client);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }
    }
}
