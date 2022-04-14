using ConstructionManagement.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using TsudaKageyu;
using ConstructionManagement.Model;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ConstructionManagement.UI
{
    public partial class FrmWindow : example
    {
        public FrmWindow()
        {
            InitializeComponent();
        }
        NotificationService notificationService = new NotificationService();
        private delegate void AsyncCallback();
        private AsyncCallback callback;
        private void FrmWindow_Load(object sender, EventArgs e)
        {
            try
            {
                callback = QueryNotification;
                Timer notification = new Timer();
                notification.Interval = 1000;
                notification.Tick += Notification_Tick;
                notification.Start();

                LoadMemo();
                InitialFileExe();

            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        FileService fileService = new FileService();

        private void LoadMemo()
        {
            var fileName = "memo.json";
            var content = fileService.GetContent(fileName);
            rtbMemo.Text = content;
        }

        private void SaveMemo()
        {
            var content = rtbMemo.Text.Trim();
            var fileName = "memo.json";
            fileService.WriteContent(content,fileName);
        }

        private void Notification_Tick(object sender, EventArgs e)
        {
            callback?.Invoke();
        }

        private void QueryNotification()
        {
            var notification = notificationService.GetNewNotification();
            if (notification == null) return;
            var tmp =rtbNotification.Tag?.ToString();
            if (string.IsNullOrEmpty(tmp))
            {
                rtbNotification.Text = notification.Content;
                rtbNotification.Tag = notification.ID;
                return;
            }
            int id = Convert.ToInt32(tmp);
            if(id != notification.ID)
            {
                rtbNotification.Text = notification.Content;
                rtbNotification.Tag = notification.ID;
            }
        }

        FrmNotification frmNotification;
        /// <summary>
        /// 公告管理界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmNotification_Click(object sender, EventArgs e)
        {
            try
            {

                var frm = new FrmValidatePwd();
                var r = frm.ShowDialog(this);
                if(r != DialogResult.OK)
                {
                    ShowMsg("密码错误");
                    return;
                }


                if(frmNotification == null || frmNotification.IsDisposed)
                {
                    frmNotification = new FrmNotification();
                    frmNotification.StartPosition = FormStartPosition.CenterScreen;
                    frmNotification.Show();
                }
                else
                {
                    frmNotification.Activate();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableLayoutPanel3_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
           // Pen pp = new Pen(Color.Black);
           // e.Graphics.DrawRectangle(pp, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Y + e.CellBounds.Height - 1);
        }


        FrmMain mainWindow;
        /// <summary>
        /// 施工管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmConstructionManager_Click(object sender, EventArgs e)
        {
            try
            {
                if(mainWindow == null || mainWindow.IsDisposed)
                {
                    FrmLogin frmLogin = new FrmLogin();
                    var dialog = frmLogin.ShowDialog();
                    if(dialog == DialogResult.OK)
                    {
                        mainWindow = new FrmMain();
                        mainWindow.Show();
                    }
                }
                else
                {
                    mainWindow.Activate();
                }
               

            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 备忘录管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDemo_Click(object sender, EventArgs e)
        {

        }

        private void FrmWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveMemo();
             //   SaveExeConfiguration();

                
            }catch(Exception ex)
            {
                ShowMsg("备忘录保存异常");
            }
        }



        #region 添加软件快捷方式
        IList<FileShortcut> files = new List<FileShortcut>();
        ImageList smallImageList = new ImageList();

        private void listExe_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                object obj = e.Data.GetData(DataFormats.FileDrop);

                var filePath = ((string[])obj)[0];

                if (Path.GetExtension(filePath).Equals(".lnk"))
                {
                    filePath = fileService.GetShortcutTargetPath(filePath);
                }


               
                if(Path.GetExtension(filePath).Equals(".exe"))
                {
                    var fileName = Path.GetFileNameWithoutExtension(filePath);
                    int hashCode = filePath.GetHashCode();
                    var imageName = fileName + hashCode.ToString();

            //        smallImageList.Images.Add(imageName, bitmap);

                    FileShortcut file = new FileShortcut
                    {
                        FileName = fileName,
                        FilePath = filePath,
                        ImageName = imageName
                    };
                    files.Add(file);

                    var image = GetBitmap(filePath);
                    if(image != null)
                    {
                        smallImageList.Images.Add(imageName, image);
                    }

                    ListViewItem item = new ListViewItem();
                    
                    item.Text = fileName;
                    item.ImageKey = imageName;
                    item.Tag = filePath;
                    listExe.SmallImageList = smallImageList;
                    listExe.Items.Add(item);
                }
                SaveExeConfiguration();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private Bitmap GetBitmap(string filePath)
        {
            var extractor = new IconExtractor(filePath);
            var icon = extractor.GetAllIcons();
            var count = icon.Count();
            if(count > 0)
            {
                var tmp = icon.LastOrDefault();
                Bitmap bitmap = new Bitmap(tmp.ToBitmap());
                return bitmap;
            }
            else
            {
                return null;
            }
        }

        private void listExe_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        #endregion

        private void listExe_DoubleClick(object sender, EventArgs e)
        {
            if(listExe.SelectedItems.Count == 1)
            {
                var filePath = listExe.SelectedItems[0].Tag.ToString();
                Process.Start(filePath);
            }
        }

        private void SaveExeConfiguration()
        {
            if (files.Count == 0) return;
            var fileName = "fileExeConfig.json";
            var content = JsonConvert.SerializeObject(files);
            fileService.WriteContent(content, fileName);
            
        }

        private void InitialFileExe()
        {
            listExe.Items.Clear();
            var fileName = "fileExeConfig.json";
            var content = fileService.GetContent(fileName);
            if (string.IsNullOrEmpty(content)) return;

            var tmp = JsonConvert.DeserializeObject<List<FileShortcut>>(content);

            foreach(var t in tmp)
            {
                files.Add(t);

                var image = GetBitmap(t.FilePath);
                if (image != null)
                {
                    smallImageList.Images.Add(t.ImageName, image);
                }

                ListViewItem item = new ListViewItem();

                item.Text = t.FileName;
                item.ImageKey = t.ImageName;
                item.Tag = t.FilePath;
                listExe.SmallImageList = smallImageList;
                listExe.Items.Add(item);
            }
            listExe.Refresh();
        }
        /// <summary>
        /// 施工材料及人员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"D:\Debug\Debug\weimin.exe";
                Process.Start(filePath);
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void tsmShortcut_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFileExe frmFileExe = new FrmFileExe();
                frmFileExe.Callback += InitialFileExe;
                frmFileExe.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void itemFileManagementSys_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"D:\Debug\资料系统\FileManagement.exe";
                Process.Start(filePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        FormTelDict frmTel;
        /// <summary>
        /// 打开备忘录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmTelDict_Click(object sender, EventArgs e)
        {
            try
            {
                if(frmTel == null || frmTel.IsDisposed)
                {
                    frmTel = new FormTelDict();
                    frmTel.Show();
                }
                else
                {
                    frmTel.Activate();
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void itemExamSys_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"D:\Debug\考试系统\MainFrame.exe";
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemNotificationPwd_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormEditNotificationPwd();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmCalculater_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
