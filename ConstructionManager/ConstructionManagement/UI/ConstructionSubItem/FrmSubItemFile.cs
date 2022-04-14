using ConstructionManagement;
using System;
using System.IO;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmSubItemFile : example
    {
        public FrmSubItemFile()
        {
            InitializeComponent();
            itemFileService = new SubItemFileService();
        }
        private SubItemFileService itemFileService;
        public ConstructionSubItem SubItem { get; set; }
        private void FrmSubItemFile_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.Authorities.Contains("B101040501"))
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }

                if (CurrentUser.Authorities.Contains("B101040502"))
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

                dgvItemFiles.DataBindingComplete += DgvItemFiles_DataBindingComplete;
                InitialData();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvItemFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvItemFiles.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void InitialData()
        {
            try
            {
                var itemFiles = itemFileService.GetItemFileByParentId(SubItem.ID);
                var r = Helper.GetSortableBindingList<SubItemFile>(itemFiles);
                dgvItemFiles.DataSource = r;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditItemFile itemFile = new FrmEditItemFile();
                itemFile.SubItem = SubItem;
                itemFile.ItemFileCallBack += InitialData;
                itemFile.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvItemFiles.DataSource == null)
                {
                    ShowMsg("请选择要删除的数据");
                    return;
                }
                var rows = dgvItemFiles.SelectedRows;
                if(rows.Count > 0)
                {
                    var itemFile = rows[0].DataBoundItem as SubItemFile;
                    itemFileService.DeleteItemFile(itemFile);
                }
                else
                {
                    ShowMsg("请选择要删除的数据");
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

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

        private void dgvItemFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    var itemFile = dgvItemFiles.Rows[e.RowIndex].DataBoundItem as SubItemFile;

                    var dir = Path.GetDirectoryName(itemFile.LocalPath);
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    if (File.Exists(itemFile.LocalPath))
                    {
                        var dialog = ShowAffirm("临时文件已存在，确认后将覆盖本地文件");
                        if(dialog == DialogResult.OK)
                        {
                            itemFileService.OpenLocalFile(itemFile);
                        }
                    }
                    else
                    {
                        itemFileService.OpenLocalFile(itemFile);
                    }
                    
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
