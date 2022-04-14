using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FileManagement.Service;
using Autofac;
using Autofac.Core.Lifetime;

namespace FileManagement.UI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开合同界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemContract_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var scope = AppContainer.Container.BeginLifetimeScope();
            var frm = scope.Resolve<FrmContract>();
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this;
            frm.Show();            
        }
        /// <summary>
        /// 打开造价界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = AppContainer.Resove<FrmConstructionCost>();
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this;
            frm.Show();
        }
        /// <summary>
        /// 打开用户资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = AppContainer.Resove<FrmClient>();
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}