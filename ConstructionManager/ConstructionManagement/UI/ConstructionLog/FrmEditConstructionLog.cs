using System;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditConstructionLog : example
    {
        public FrmEditConstructionLog()
        {
            InitializeComponent();
        }
        ConstructionLogService logService = new ConstructionLogService();
        ConstructionNodeService nodeService = new ConstructionNodeService();
        public ConstructionLog Log { get; set; }
        public bool IsAdd { get; set; } = false;
        public bool IsPrint { get; set; } = false;
        public delegate void EditLogRefresh();
        public event EditLogRefresh CallBack;
        private void FrmEditConstructionLog_Load(object sender, EventArgs e)
        {
            try
            {
                InitialData();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        ExcelService excelService = new ExcelService();

        private void InitialData()
        {

            var nodes = nodeService.GetConstructionNodes();
            cbConstructionNode.DataSource = nodes;
            cbConstructionNode.DisplayMember = "Name";
            cbConstructionNode.ValueMember = "ConstructionNo";
            cbConstructionNode.SelectedIndex = -1;
            if (!IsAdd || IsPrint)
            {
                dtDate.Value = Convert.ToDateTime(Log.LogDate);
                txtWeather.Text = Log.Weather;
                txtTemperature.Text = Log.Temperature;
                txtEvent.Text = Log.ConstructionEvent;
                txtWind.Text = Log.Wind;
                txtPeople.Text = Log.People;
                rtbProduct.Text = Log.ConstructionDescription;
                rtbSecure.Text = Log.SecurityLog;
                cbConstructionNode.SelectedValue = Log.ConstructionCode;
            }

            if (IsPrint)
            {
                btnSubmit.Visible = false;
                txtEvent.Enabled = false;
                txtPeople.Enabled = false;
                txtTemperature.Enabled = false;
                txtWeather.Enabled = false;
                txtWind.Enabled = false;
                rtbProduct.Enabled = false;
                rtbSecure.Enabled = false;
                dtDate.Enabled = false;
            }
            else
            {
                btnPrint.Visible = false;
            }
        }

        delegate void PrintLog();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                PrintLog printDelegate = PrintConstuctionLog;
                this.Invoke(printDelegate);
                
                ShowMsg("打印成功");
                Close();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        void PrintConstuctionLog()
        {
            excelService.PrintConstructionLog(Log);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var logDate = dtDate.Value;
                var weather = txtWeather.Text;
                var temperature = txtTemperature.Text;
                var constructionEvent = txtEvent.Text;
                var wind = txtWind.Text;
                var people = txtPeople.Text;
                var desc = rtbProduct.Text;
                var secure = rtbSecure.Text;
                var constructionName = cbConstructionNode.Text;
                var constructionCode = cbConstructionNode.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(constructionCode))
                {
                    ShowMsg("请选择施工项目");
                    return;
                }

                var log = new ConstructionLog
                {
                    LogDate = logDate.ToString("yyyy-MM-dd"),
                    Weather = weather,
                    Temperature = temperature,
                    ConstructionEvent = constructionEvent,
                    Wind = wind,
                    People = people,
                    ConstructionDescription = desc,
                    SecurityLog = secure,
                    ConstructionCode = constructionCode,
                    ConstructionName = constructionName
                };

                if (IsAdd)
                {
                    logService.AddConstructionLog(log);
                }
                else
                {
                    log.ID = Log.ID;
                    logService.UpdateConstruction(log);
                }
                ShowMsg("提交成功");
                CallBack?.Invoke();
                Close();

            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
