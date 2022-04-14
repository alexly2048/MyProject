using ExpensesSysLib.Helper;
using ExpensesSysLib.Models;
using ExpensesSysLib.Services;
using ExpensesSysLib.Views;
using Microsoft.Win32;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysUI.Views
{
    public class ConstructItemView : BaseEntity
    {
        public ConstructItemView()
        {
            itemService = new ConstructItemService();
            officeService = new AdministrativeOfficeService();
            constructService = new ConstructService();
            constructItemParam = new ConstructItemParamView();

            exportHeaders = new Dictionary<string, string>
            {
                {"OfficeName","科室名称" },
                {"ConstructName","项目名称" },
                {"SecondaryConstructName","二级项目类别" },
                {"TopConstructName","一级项目类别" },
                {"BudgetName","预算科目" },
                {"DepartmentName","部门" },
                {"Name","明细名称" },
                {"Unit","单位" },
                {"QTY","数量" },
                {"Price","单价" },
                {"Money","金额" },
                {"Surplus","余额" },
                {"ActualExpense","支出" },
                {"Contractor","承办人" },
                {"ProcurementMode","采购方式" },
                {"PlanCompletedDate","计划完成日期" },
                {"ActualCompletedDate","支出日期" },
                {"ApprovalMode","审批方式" },
                {"Remark","备注" }   
            };
        }



        private readonly ConstructItemService itemService;
        private readonly AdministrativeOfficeService officeService;
        private readonly ConstructService constructService;
        private ConstructItemParamView constructItemParam;
        private ObservableCollection<ConstructItemViewModel> constructItems;
        private ConstructItemViewModel selectedConstructItem;
        private ConstructItem addConstructItem;
        private ConstructViewModel selectedConstruct;
        private ObservableCollection<ConstructViewModel> constructs;
        private string key;
        private Dictionary<string, string> exportHeaders;
        public string Key
        {
            get { return key; }
            set { key = value; RaisePropertyChanged(); }
        }

        public ConstructItemParamView ConstructItemParam
        {
            get { return constructItemParam; }
            set { constructItemParam = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<ConstructItemViewModel> ConstructItems
        {
            get { return constructItems; }
            set { constructItems = value; RaisePropertyChanged(); }
        }

        public ConstructItemViewModel SelectedConstructItem
        {
            get { return selectedConstructItem; }
            set { selectedConstructItem = value; RaisePropertyChanged(); }
        }

        internal async Task ExportToExcel()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "excel2007|*.xlsx";
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.FileName))
            {
                await DialogHelper.ShowAffirmative("请选择要导出的文件");
                return;
            }

            if (File.Exists(dialog.FileName))
                File.Delete(dialog.FileName);

            using (var fs = new FileStream(dialog.FileName, FileMode.CreateNew, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet();

                var header = sheet.CreateRow(0);
                int index = 0;
                foreach (var key in exportHeaders.Keys)
                {
                    ICell cell = header.CreateCell(index);
                    cell.SetCellValue(exportHeaders[key]);
                    index++;
                }

                var type = typeof(ConstructItemViewModel);
                for (int i = 0; i < ConstructItems.Count; i++)
                {
                    var row = sheet.CreateRow(i + 1);
                    index = 0;
                    foreach (var key in exportHeaders.Keys)
                    {
                        ICell cell = row.CreateCell(index);
                        cell.SetCellValue(type.GetProperty(key).GetValue(ConstructItems[i])?.ToString()??string.Empty);
                        index++;
                    }
                }

                workbook.Write(fs);
            }
        }

        public ConstructItem AddConstructItem
        {
            get { return addConstructItem; }
            set { addConstructItem = value; RaisePropertyChanged(); }
        }

        public ConstructViewModel SelectedConstruct
        {
            get { return selectedConstruct; }
            set { selectedConstruct = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<ConstructViewModel> Constructs
        {
            get { return constructs; }
            set { constructs = value; RaisePropertyChanged(); }
        }


        public async Task Refresh()
        {
            var r = await itemService.QueryConstructItemsAsync();
            if (!string.IsNullOrEmpty(ConstructItemParam.BudgetName))
                r = r.Where(x => x.BudgetName.Contains(ConstructItemParam.BudgetName));
            if (!string.IsNullOrEmpty(ConstructItemParam.TopConstructName))
                r = r.Where(x => x.TopConstructName.Contains(ConstructItemParam.TopConstructName));
            if (!string.IsNullOrEmpty(ConstructItemParam.SecondaryConstructName))
                r = r.Where(x => x.SecondaryConstructName.Contains(ConstructItemParam.SecondaryConstructName));
            if (!string.IsNullOrEmpty(ConstructItemParam.ConstructItemName))
                r = r.Where(x => x.Name.Contains(ConstructItemParam.ConstructItemName));
            if (!string.IsNullOrEmpty(ConstructItemParam.OfficeName))
                r = r.Where(x => x.OfficeName.Contains(ConstructItemParam.OfficeName));

            if (ConstructItemParam.ActualCompletedDateStart.HasValue)
            {
                var start = (DateTime)ConstructItemParam.ActualCompletedDateStart;
                start = new DateTime(start.Year, start.Month, start.Month);
                r = r.Where(x => x.ActualCompletedDate >= start);
            }
            if (ConstructItemParam.ActualCompletedDateEnd.HasValue)
            {
                var end = (DateTime)ConstructItemParam.ActualCompletedDateEnd;
                end = new DateTime(end.Year, end.Month, end.Month);
                r = r.Where(x => x.ActualCompletedDate >= end);
            }

            ConstructItems = new ObservableCollection<ConstructItemViewModel>(r);
        }

        internal async Task DeleteConstructItemAsync()
        {
            if (SelectedConstructItem == null)
                return;
            await itemService.DeleteConstructItemAsync(SelectedConstructItem.ConstructItemID);
            await Refresh();
            await ActualExpenseHelper.CalcActualExpenseAsync();
        }

        public async Task AddConstructItemAsync()
        {
            if (AddConstructItem == null)
                return;
            if (SelectedConstruct == null)
                return;

            AddConstructItem.ConstructID = SelectedConstruct.ConstructID;
            await itemService.AddConstructItemAsync(AddConstructItem);
            await Refresh();
        }

        public async Task UpdateConstructItemAsync()
        {
            if (SelectedConstructItem == null)
                return;
            if (SelectedConstruct == null)
                return;

            var item = new ConstructItem
            {
                ConstructItemID = SelectedConstructItem.ConstructItemID,
                Name = SelectedConstructItem.Name,
                QTY = SelectedConstructItem.QTY,
                Money = SelectedConstructItem.Money,
                Surplus = SelectedConstructItem.Surplus,
                ActualExpense = SelectedConstructItem.ActualExpense,
                ActualCompletedDate = SelectedConstructItem.ActualCompletedDate,
                PlanCompletedDate = SelectedConstructItem.PlanCompletedDate,
                ConstructID = SelectedConstruct.ConstructID,
                Contractor = SelectedConstructItem.Contractor,
                ApprovalMode = SelectedConstructItem.ApprovalMode,
                Price = SelectedConstructItem.Price,
                ProcurementMode = SelectedConstructItem.ProcurementMode,
                Remark = SelectedConstructItem.Remark,
                Unit = SelectedConstructItem.Unit
            };

            await itemService.UpdateConstructItemAsync(item);
            await Refresh();
        }


        public async Task RefreshBindingSourcesAsync()
        {
            if (SelectedConstructItem == null)
            {
                Constructs = null;
                SelectedConstruct = null;
            }
            else
            {
                Constructs = new ObservableCollection<ConstructViewModel>(await constructService.QueryConstructsAsync(string.Empty));
                SelectedConstruct = Constructs.FirstOrDefault(x => x.ConstructID.Equals(SelectedConstructItem.ConstructID));
            }
        }

        public async Task RefreshConstructAsync()
        {
            Constructs = new ObservableCollection<ConstructViewModel>(await constructService.QueryConstructsAsync(Key));
        }
    }
}
