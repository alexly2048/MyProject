using CustomerUI.DBService.QuestionService;
using CustomerUI.Model;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraGrid.Views.Grid;
using IOCService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormManageQuestion : FormBase
    {
        public FormManageQuestion(DisplayQuestionViewService questionViewService,
            QuestionViewService viewService)
        {
            InitializeComponent();
            this.questionViewService = questionViewService;
            this.viewService = viewService;
        }
        private readonly DisplayQuestionViewService questionViewService;
        private readonly QuestionViewService viewService;
        private void FormManageQuestion_Load(object sender, EventArgs e)
        {
            InitialUI();
            SetAuthories();
            QueryData();
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("A101")))
            {
                btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("A102")))
            {
                btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("A103")))
            {
                btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("A104")))
            {
                btnDelete.Enabled = false;
            }
        }

        private void InitialUI()
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;
            gridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;

            var questionTypes = QuestionType.GetQuestionTypes();
            lookupType.Properties.DataSource = questionTypes;
            lookupType.Properties.DisplayMember = "DisplayText";
            lookupType.Properties.ValueMember = "ValueMember";
            lookupType.ItemIndex = -1;
        }

        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.FieldName.Equals("SUBJECT_TYPE"))
            {
                var type = (SubjectTypeEnum)Enum.Parse(typeof(SubjectTypeEnum), e.Value.ToString());
                e.DisplayText = QuestionDict.SubjectTypeDict[type];
            }
            if (e.Column.FieldName.Equals("QUESTION_TYPE"))
            {
                e.DisplayText = QuestionDict.QuestionTypeDict[(QuestionTypeEnum)Enum.Parse(typeof(QuestionTypeEnum),e.Value.ToString())];
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FormAddQuestion>();
            frm.Shower(QueryData,true,null);
        }

        private void QueryData()
        {
            var search = new SearchItemView();
            var key = tKeyword.Text.Trim();
            search.Keyword = key;
            var type = lookupType.EditValue?.ToString();
            QuestionTypeEnum qType;
            if (!string.IsNullOrEmpty(type))
            {
                qType = (QuestionTypeEnum)Convert.ToInt32(type);
                search.QuestionType = qType;
            }
            var r = questionViewService.GetDisplayQuestionViews(search);
            if (r.Any())
            {
                bdsoure.DataSource = r;
            }
            else
            {
                ShowMsg("未查询到数据");
                bdsoure.DataSource = null;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var view = sender as GridView;
            var arg = e as MouseEventArgs;
            var hitInfo = view.CalcHitInfo(arg.X, arg.Y);
            if(arg.Button == MouseButtons.Left && hitInfo.InDataRow)
            {
                var data = view.GetRow(hitInfo.RowHandle) as DisplayQuestionView;
                if (hitInfo.Column.Name.Equals("colDESCRIPTION"))
                {
                    var frm = AppContainer.Resolve<FormSubjectDescription>();
                    frm.Shower(QueryData, true, data);
                }
                if (hitInfo.Column.Name.Equals("colSELECT_ITEMS"))
                {
                    var frm = AppContainer.Resolve<FormEditQuestion>();
                    frm.Shower(null, true, data);
                }
                if (hitInfo.Column.Name.Equals("colIMAGE"))
                {
                    var frm = AppContainer.Resolve<FormQuestionImages>();
                    frm.Shower(null, true, data);
                }
            }
        }
        /// <summary>
        /// 修改问题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayQuestionView;
                var frm = AppContainer.Resolve<FormEditQuestion>();
                frm.Shower(null, true, data);
            }
            else
            {
                ShowMsg("请选择要更新的数据");
            }
        }
        /// <summary>
        /// 删除问题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayQuestionView;
                if(ShowAffirm("是否删除选择的数据？\r\n确认后，将删除该问题所有数据") == DialogResult.OK)
                {
                    viewService.DeleteQuestion(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }
    }
}
