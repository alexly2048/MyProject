using ConstructionManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagement.UI
{
    public partial class FrmMain : example
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmConstructionNode constructionNode;
        private void button2_Click(object sender, EventArgs e)
        {
            if(constructionNode == null || constructionNode.IsDisposed)
            {
                constructionNode= new FrmConstructionNode();
                constructionNode.Show();
            }
            else
            {
                constructionNode.Activate();
            }
             
        }
        FrmConstructionOverallSchedule overallSchedule;
        private void button1_Click(object sender, EventArgs e)
        {
            if(overallSchedule ==null || overallSchedule.IsDisposed)
            {
                overallSchedule = new FrmConstructionOverallSchedule();
                overallSchedule.Show();
            }
            else
            {
                overallSchedule.Activate();
            }
        }

        

        FrmConstructionOverallSchedule frmOverallSchedule;
        /// <summary>
        /// 打开施工总进度窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmOverallSchedule_Click(object sender, EventArgs e)
        {
            if(frmOverallSchedule == null || frmOverallSchedule.IsDisposed)
            {
                frmOverallSchedule = new FrmConstructionOverallSchedule();
                frmOverallSchedule.Show();
            }
            else
            {
                frmOverallSchedule.Activate();
            }
        }

        FrmAcceptance frmMiddleAcceptance;
        /// <summary>
        /// 打开中间验收窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemMiddleAcceptance_Click(object sender, EventArgs e)
        {
            if(frmMiddleAcceptance == null || frmMiddleAcceptance.IsDisposed)
            {
                frmMiddleAcceptance = new FrmAcceptance();
                frmMiddleAcceptance.ProjectKind = Model.ProjectKindEnum.Middle;
                frmMiddleAcceptance.Show();
            }
            else
            {
                frmMiddleAcceptance.Activate();
            }
            
        }

        FrmAcceptance frmFinalAcceptance;
        /// <summary>
        /// 打开竣工验收窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemFinalAcceptance_Click(object sender, EventArgs e)
        {
            try
            {
                if(frmFinalAcceptance == null || frmFinalAcceptance.IsDisposed)
                {
                    frmFinalAcceptance = new FrmAcceptance();
                    frmFinalAcceptance.ProjectKind = Model.ProjectKindEnum.Final;
                    frmFinalAcceptance.Show();
                }
                else
                {
                    frmFinalAcceptance.Activate();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var threadDir = AppDomain.CurrentDomain.BaseDirectory;
                var path = Path.Combine(threadDir, "tmp");
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    Directory.CreateDirectory(path);
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        FrmLoginUser frmUser;
        private void tmsUserManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmUser == null || frmUser.IsDisposed)
                {
                    frmUser = new FrmLoginUser();
                    frmUser.Show();
                }
                else
                {
                    frmUser.Activate();
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        FrmAuthority frmAuthority;
        /// <summary>
        /// 打开权限管理窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAuthorityManagement_Click(object sender, EventArgs e)
        {
            try
            {
                if(frmAuthority == null || frmAuthority.IsDisposed)
                {
                    frmAuthority = new FrmAuthority();
                    frmAuthority.Show();
                }
                else
                {
                    frmAuthority.Activate();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("A1"))
                {
                    tsmConstructionNode.Enabled = true;
                }
                else
                {
                    tsmConstructionNode.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B1"))
                {
                    tsmOverallSchedule.Enabled = true;
                }
                else
                {
                    tsmOverallSchedule.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("C1"))
                {
                    tsmAcceptance.Enabled = true;
                }
                else
                {
                    tsmAcceptance.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("D1"))
                {
                    tsmSystemManagement.Enabled = true;
                }
                else
                {
                    tsmSystemManagement.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("C101"))
                {
                    itemMiddleAcceptance.Enabled = true;
                }
                else
                {
                    itemMiddleAcceptance.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("C102"))
                {
                    itemFinalAcceptance.Enabled = true;
                }
                else
                {
                    itemFinalAcceptance.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("D101"))
                {
                    tmsUserManager.Enabled = true;
                }
                else
                {
                    tmsUserManager.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("D102"))
                {
                    tsmAuthorityManagement.Enabled = true;
                }
                else
                {
                    tsmAuthorityManagement.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("A101"))
                {
                    itemConstructionNode.Enabled = true;
                }
                else
                {
                    itemConstructionNode.Enabled = false;
                }
                if (CurrentUser.Authorities.Contains("A102"))
                {
                    itemConstructionLog.Enabled = true;
                }
                else
                {
                    itemConstructionLog.Enabled = false;
                }

                SetBackgroudImage();

            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        FrmConstructionLog frmConstructionLog;
        private void itemConstructionLog_Click(object sender, EventArgs e)
        {
            try
            {
                if(frmConstructionLog == null || frmConstructionLog.IsDisposed)
                {
                    frmConstructionLog = new FrmConstructionLog();
                    frmConstructionLog.Show();
                }
                else
                {
                    frmConstructionLog.Activate();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        FrmConstructionNode frmNode;
        private void itemConstructionNode_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmNode == null || frmNode.IsDisposed)
                {
                    frmNode = new FrmConstructionNode();
                    frmNode.Show();
                }
                else
                {
                    frmNode.Activate();
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void itemChangeBackground_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Multiselect = false;
                dialog.Filter = "Jpg图像|*.jpg|BMP图像|*.bmp|PNG图像|*.png|其他文件|*.*";
                var filePath = string.Empty;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
                if (!File.Exists(filePath))
                {
                    ShowMsg("选择文件不存在");
                    return;
                }

                Image image = Image.FromFile(filePath);
                var con = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                con.AppSettings.Settings["MainBackground"].Value = filePath;
                con.Save();
                this.BackgroundImage = image;
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void SetBackgroudImage()
        {
            var filePath = ConfigurationManager.AppSettings["MainBackground"];
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }
            if (!File.Exists(filePath))
            {
                return;
            }
            Image image = Image.FromFile(filePath);         
            this.BackgroundImage = image;
        }
    }
}
