using ConstructionManagement;
using System;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmAcceptanceImage : example
    {
        public FrmAcceptanceImage()
        {
            InitializeComponent();
        }
        AcceptanceImageService imageService = new AcceptanceImageService();
        public ImageKindEnum ImageKind { get; set; }
        public Acceptance Acceptance { get; set; }

        
        private void FrmAccptanceImage_Load(object sender, EventArgs e)
        {
            try
            {
                dgvImages.DataBindingComplete += DgvImages_DataBindingComplete;
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void DgvImages_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
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
                var parentId = Acceptance.ID;
                var result = imageService.GetAcceptanceImages(parentId,ImageKind);
                var r = Helper.GetSortableBindingList<AcceptanceImage>(result);
                dgvImages.DataSource = r;
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
                FrmAddAcceptanceImage addImage = new FrmAddAcceptanceImage();
                addImage.Acceptance = Acceptance;
                addImage.ImageKind = ImageKind;
                addImage.CallBack += InitialData;
                addImage.ShowDialog();
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvImages.SelectedRows;
                if(rows.Count > 0)
                {
                    var acceptanceImage = rows[0].DataBoundItem as AcceptanceImage;
                    imageService.DeleteAcceptanceImage(acceptanceImage);
                    ShowMsg("删除成功");
                    InitialData();
                }
                else
                {
                    ShowMsg("请选择要删除的数据行");
                }
            }
            catch (Exception ex)
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

        private void dgvImages_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    var acceptanceIamge = dgvImages.Rows[e.RowIndex].DataBoundItem as AcceptanceImage;
                    imageService.OpenLocalTmpFile(acceptanceIamge);
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
