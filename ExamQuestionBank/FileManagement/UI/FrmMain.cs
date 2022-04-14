using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IOCService.Service;
using CustomerUI.UI.Common;
using CustomerUI;
using CustomerUI.UI.QuestionBank;

namespace FileManagement.UI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Dictionary<string, Form> forms = new Dictionary<string, Form>();
        private void Shower<T>(Form win) where T:Form
        {
            var t = typeof(T);
            if (forms.ContainsKey(t.Name))
            {
                forms[t.Name].Activate();
            }
            else
            {              
                var frm = AppContainer.Resolve<T>();
                forms.Add(t.Name,frm);
                frm.Dock = DockStyle.Fill;
                frm.MdiParent = win;
                frm.FormClosing += FrmMain_FormClosing;
                frm.Show();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (sender as Form);
            var name = form.GetType().Name;
            forms.Remove(name);
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            barItemUserId.Caption = AppHost.CurrentUser.UserId;
            barItemUserName.Caption = AppHost.CurrentUser.UserName;
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("L1")))
            {
                itemUserManagement.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("M1")))
            {
                itemAuthorities.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("A1")))
            {
                itemQM.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("B1")))
            {
                itemCourse.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("C1")))
            {
                itemGrade.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("D1")))
            {
                itemExamBank.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E1")))
            {
                itemUserExam.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("F1")))
            {
                itemSelectExam.Enabled = false;
            }
        }
        /// <summary>
        /// 打开用户管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {        
            Shower<FrmUser>(this);
        }
        /// <summary>
        /// 用户权限管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FrmAuthority>(this);
        }

        /// <summary>
        /// 打开试卷界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemQuestion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormExam>(this);
        }
        /// <summary>
        /// 打开试卷管理界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemQM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormManageQuestion>(this);
        }

        private void itemCourse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormCourse>(this);
        }
        /// <summary>
        /// 打开年级管理界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemGrade_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormGrade>(this);
        }
        /// <summary>
        /// 用户设置试卷库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemExamBank_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormExamBank>(this);
        }

        private void itemUserExam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormManageUserExam>(this);
        }
        /// <summary>
        /// 用户打开界面查看自己的考试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemSelectExam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Shower<FormSelectExam>(this);
        }
    }
}