using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmEditSchedule : example
    {
        public FrmEditSchedule()
        {
            InitializeComponent();
            scheduleService = new ConstructionOverallScheduleService();
        }
        private ConstructionOverallScheduleService scheduleService;
        public ConstructionOverallSchedule OverallSchedule { get; set; }
        public bool IsAdd { get; set; }

        private void FrmEditSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsAdd)
                {
                    txtProjectCode.Text = OverallSchedule.ProjectCode;
                    txtProjectCode.ReadOnly = true;
                    txtProjectName.Text = OverallSchedule.ProjectName;
                }
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var projectCode = txtProjectCode.Text.Trim();
                var projectName = txtProjectName.Text.Trim();
                if (string.IsNullOrEmpty(projectCode))
                {
                    ShowMsg("请输入项目编码");
                    return;
                }
                if (string.IsNullOrEmpty(projectName))
                {
                    ShowMsg("请输入项目名称");
                    return;
                }

                var schedule = new ConstructionOverallSchedule
                {
                    ProjectCode = projectCode,
                    ProjectName = projectName
                };
                /*
                if (IsAdd)
                {
                    scheduleService.AddSchedule(schedule);
                }
                else
                {
                    schedule.ID = OverallSchedule.ID;
                    scheduleService.UpdateSchedule(schedule);                    
                }
                */
                ShowMsg("提交成功");
                Close();
                
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
