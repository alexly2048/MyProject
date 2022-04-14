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
    public class ConstructView : BaseEntity
    {
        public ConstructView()
        {
            constructService = new ConstructService();
            officeService = new AdministrativeOfficeService();
            secondaryService = new SecondaryConstructService();
            constructParam = new ConstructParamView();
        }
        private readonly ConstructService constructService;
        private readonly AdministrativeOfficeService officeService;
        private readonly SecondaryConstructService secondaryService;
        private ConstructParamView constructParam;
        private ObservableCollection<ConstructViewModel> constructs;
        private ConstructViewModel selectedConstruct;
        private Construct addConstruct;
        private SecondaryConstructViewModel selectedSecondaryConstruct;
        private ObservableCollection<SecondaryConstructViewModel> secondaryConstructs;
        private ObservableCollection<AdministrativeOffice> offices;
        private AdministrativeOffice selectedOffice;
        private string key;
        public string Key
        {
            get { return key; }
            set { key = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<AdministrativeOffice> Offices
        {
            get { return offices; }
            set { offices = value; RaisePropertyChanged(); }
        }

        public AdministrativeOffice SelectedOffice
        {
            get { return selectedOffice; }
            set { selectedOffice = value; RaisePropertyChanged(); }
        }

        public ConstructParamView ConstructParam
        {
            get { return constructParam; }
            set { constructParam = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<ConstructViewModel> Constructs
        {
            get { return constructs; }
            set { constructs = value; RaisePropertyChanged(); }
        }

        public ConstructViewModel SelectedConstruct
        {
            get { return selectedConstruct; }
            set { selectedConstruct = value; RaisePropertyChanged(); }
        }

        public Construct AddConstruct
        {
            get { return addConstruct; }
            set { addConstruct = value; RaisePropertyChanged(); }
        }

        public SecondaryConstructViewModel SelectedSecondaryConstruct
        {
            get { return selectedSecondaryConstruct; }
            set { selectedSecondaryConstruct = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<SecondaryConstructViewModel> SecondaryConstructs
        {
            get { return secondaryConstructs; }
            set { secondaryConstructs = value; RaisePropertyChanged(); }
        }


        public async Task Refresh()
        {
            var r = await constructService.QueryConstructsAsync(string.Empty);
            if (!string.IsNullOrEmpty(ConstructParam.BudgetName))
                r = r.Where(x => x.BudgetName.Contains(ConstructParam.BudgetName));
            if (!string.IsNullOrEmpty(ConstructParam.TopConstructName))
                r = r.Where(x => x.TopConstructName.Contains(ConstructParam.TopConstructName));
            if (!string.IsNullOrEmpty(ConstructParam.SecondaryConstructName))
                r = r.Where(x => x.SecondaryConstructName.Contains(ConstructParam.SecondaryConstructName));
            if (!string.IsNullOrEmpty(ConstructParam.ConstructName))
                r = r.Where(x => x.Name.Contains(ConstructParam.ConstructName));
            if (!string.IsNullOrEmpty(ConstructParam.OfficeName))
                r = r.Where(x => x.OfficeName.Contains(ConstructParam.OfficeName));

            if (ConstructParam.ActualCompletedDateStart.HasValue)
            {
                var start = (DateTime)ConstructParam.ActualCompletedDateStart;
                start = new DateTime(start.Year, start.Month, start.Month);
                r = r.Where(x => x.ActualCompletedDate >= start);
            }
            if (ConstructParam.ActualCompletedDateEnd.HasValue)
            {
                var end = (DateTime)ConstructParam.ActualCompletedDateEnd;
                end = new DateTime(end.Year, end.Month, end.Month);
                r = r.Where(x => x.ActualCompletedDate >= end);
            }

            Constructs = new ObservableCollection<ConstructViewModel>(r);
        }

        internal async Task DeleteConstructAsync()
        {
            if (SelectedConstruct == null)
                return;
            await constructService.DeleteConstructAsync(SelectedConstruct.ConstructID);
            await Refresh();
            await ActualExpenseHelper.CalcActualExpenseAsync();
        }

        public async Task AddConstructAsync()
        {
            if (AddConstruct == null)
                return;
            if (SelectedSecondaryConstruct == null)
                return;

            if (SelectedOffice == null)
                return;

            AddConstruct.OfficeID = SelectedOffice.OfficeID;
            AddConstruct.SecondaryConstructID = SelectedSecondaryConstruct.SecondaryConstructID;

            await constructService.AddConstructAsync(AddConstruct);
            await Refresh();
        }

        public async Task UpdateConstructAsync()
        {
            if (SelectedConstruct == null)
                return;
            if (SelectedSecondaryConstruct == null)
                return;
            if (SelectedOffice == null)
                return;

            var item = new Construct
            {
                ConstructID = SelectedConstruct.ConstructID,
                Name = SelectedConstruct.Name,
                QTY = SelectedConstruct.QTY,
                Money = SelectedConstruct.Money,
                Surplus = SelectedConstruct.Surplus,
                ActualExpense = SelectedConstruct.ActualExpense,
                ActualCompletedDate = SelectedConstruct.ActualCompletedDate,
                PlanCompletedDate = SelectedConstruct.PlanCompletedDate,
                OfficeID = SelectedOffice.OfficeID,
                SecondaryConstructID = SelectedSecondaryConstruct.SecondaryConstructID,
                Contractor = SelectedConstruct.Contractor,
                ApprovalMode = SelectedConstruct.ApprovalMode,
                Price = SelectedConstruct.Price,
                ProcurementMode = SelectedConstruct.ProcurementMode,
                Remark = SelectedConstruct.Remark,
                Unit = SelectedConstruct.Unit
            };

            await constructService.UpdateConstructAsync(item);
            await Refresh();
        }


        public async Task RefreshBindingSourcesAsync()
        {
            Offices = new ObservableCollection<AdministrativeOffice>(await officeService.QueryAdministrativeOfficesAsync());
            if (SelectedConstruct == null)
            {
                SelectedOffice = null;
                SecondaryConstructs = null;
                SelectedSecondaryConstruct = null;
            }
            else
            {
                SelectedOffice = Offices.FirstOrDefault(x => x.OfficeID.Equals(SelectedConstruct.OfficeID));
                var secs = new ObservableCollection<SecondaryConstructViewModel>(await secondaryService.QuerySecondaryConstructsAsync(string.Empty));
                SecondaryConstructs = new ObservableCollection<SecondaryConstructViewModel>(secs.Where(x => x.DepartmentID.Equals(SelectedConstruct.DepartmentID)));
                SelectedSecondaryConstruct = SecondaryConstructs.FirstOrDefault(x => x.SecondaryConstructID.Equals(SelectedConstruct.SecondaryConstructID));
            }
        }

        public async Task RefreshSecondaryConstructAsync()
        {
            if (SelectedOffice == null)
                return;
            var r = new ObservableCollection<SecondaryConstructViewModel>(await secondaryService.QuerySecondaryConstructsAsync(Key));
            SecondaryConstructs = new ObservableCollection<SecondaryConstructViewModel>(r.Where(x => x.DepartmentID.Equals(SelectedOffice.DepartmentID)));
        }
    }
}
