using ConstructionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    /// <summary>
    /// 子项附件图片
    /// </summary>
    public partial class FrmItemImage : example
    {
        public FrmItemImage()
        {
            InitializeComponent();
            imageService = new SubItemImageService();
        }
        private SubItemImageService imageService;
        public ConstructionSubItem SubItem { get; set; }
        private void FrmItemImage_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("B101040401"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B101040402"))
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

                dgvImages.DataBindingComplete += DgvImages_DataBindingComplete;
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvImages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvImages.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            try 
            {
                dgvImages.DataSource = null;
                var parentId = SubItem.ID;
                var itemImages = imageService.GetImagesByParentId(parentId);

                var r = Helper.GetSortableBindingList<SubItemImage>(itemImages);
                dgvImages.DataSource = r;
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditItemImage editImage = new FrmEditItemImage();
                editImage.SubItem = SubItem;
                editImage.ItemImageCallBack += InitialData;
                editImage.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                displayImage.Image = null;
                var rows = dgvImages.SelectedRows;
                if(rows.Count > 0)
                {
                    var itemImage = rows[0].DataBoundItem as SubItemImage;
                    var dialog = ShowAffirm("是否删除选定的数据");
                    if(dialog == DialogResult.OK)
                    {
                        imageService.DeleteSubImage(itemImage);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void dgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvImages.DataSource == null) return;
                if (e.RowIndex >= 0)
                {
                    var itemImage = dgvImages.Rows[e.RowIndex].DataBoundItem as SubItemImage;
                    if (e.ColumnIndex == dgvImages.Columns["thumbnailImageDataGridViewImageColumn"].Index)
                    {
                        FileStream fs = new FileStream(itemImage.ImageRemotePath, FileMode.Open, FileAccess.Read);
                        displayImage.Image = Image.FromStream(fs);
                        fs.Close();
                        fs.Dispose();
                    }
                    
                    if(e.ColumnIndex == dgvImages.Columns["imageFullNameDataGridViewTextBoxColumn"].Index)
                    {
                        var dir = Path.GetDirectoryName(itemImage.LocalPath);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }

                        if (File.Exists(itemImage.LocalPath))
                        {
                            var dialog = ShowAffirm("临时文件已存在，是否重新下载？");
                            if (dialog == DialogResult.OK)
                            {
                                File.Copy(itemImage.ImageRemotePath, itemImage.LocalPath, true);
                            }
                        }
                        else
                        {
                            File.Copy(itemImage.ImageRemotePath, itemImage.LocalPath);
                        }
                        System.Diagnostics.Process.Start(itemImage.LocalPath);
                    }               
                }
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
