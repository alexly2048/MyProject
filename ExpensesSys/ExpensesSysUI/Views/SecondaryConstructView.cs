using ExpensesSysLib.Models;
using ExpensesSysLib.Services;
using ExpensesSysLib.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysUI.Views
{
    public class SecondaryConstructView:BaseEntity
    {
        public SecondaryConstructView()
        {
            secondaryService = new SecondaryConstructService();
            budgetService = new BudgetService();
            depService = new DepartmentService();
            topService = new TopConstructService();
        }
        private readonly SecondaryConstructService secondaryService;
        private readonly TopConstructService topService;
        private readonly BudgetService budgetService;
        private readonly DepartmentService depService;
        private ObservableCollection<Budget> budgets;
        private Budget selectedBudget;
        private ObservableCollection<Department> departments;
        private Department selectedDepartment;
        private ObservableCollection<TopConstructCategory> topConstructs;
        private TopConstructCategory selectedTopConstruct;
        private ObservableCollection<SecondaryConstructViewModel> secondaryConstructs;
        private SecondaryConstructViewModel selectedSecondaryConstruct;
        private SecondaryConstructCategory addSecondaryConstruct;
        private string key;

        public ObservableCollection<Budget> Budgets
        {
            get { return budgets; }
            set { budgets = value; RaisePropertyChanged(); }
        }
        public Budget SelectedBudget
        {
            get { return selectedBudget; }
            set { selectedBudget = value; RaisePropertyChanged(); }
        }
        public ObservableCollection<Department> Departments
        {
            get { return departments; }
            set { departments = value; RaisePropertyChanged(); }
        }
        public Department SelectedDepartment
        {
            get { return selectedDepartment; }
            set { selectedDepartment = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<TopConstructCategory> TopConstructs
        {
            get { return topConstructs; }
            set { topConstructs = value; RaisePropertyChanged(); }
        }

        public TopConstructCategory SelectedTopConstruct
        {
            get { return selectedTopConstruct; }
            set { selectedTopConstruct = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<SecondaryConstructViewModel> SecondaryConstructs
        {
            get { return secondaryConstructs; }
            set { secondaryConstructs = value;RaisePropertyChanged(); }
        }

        public SecondaryConstructViewModel SelectedSecondaryConstruct
        {
            get { return selectedSecondaryConstruct; }
            set { selectedSecondaryConstruct = value;RaisePropertyChanged(); }
        }

        public SecondaryConstructCategory AddSecondaryConstruct
        {
            get { return addSecondaryConstruct; }
            set
            {
                addSecondaryConstruct = value;
                RaisePropertyChanged();
            }
        }
        public string Key
        {
            get { return key; }
            set { key = value; RaisePropertyChanged(); }
        }


        public async Task Refresh()
        {
            SecondaryConstructs = new ObservableCollection<SecondaryConstructViewModel>(await secondaryService.QuerySecondaryConstructsAsync(Key));
        }

        public async Task AddSecondaryConstructAsync()
        {
            if (selectedTopConstruct == null)
                return;

            addSecondaryConstruct.TopConstructID = selectedTopConstruct.TopConstructID;
            await secondaryService.AddSecondaryConstructAsync(addSecondaryConstruct);
            await Refresh();
        }

        public async Task UpdateSecondaryConstructAsync()
        {
            if (selectedTopConstruct == null)
                return;

            var secondary = new SecondaryConstructCategory
            {
                SecondaryConstructID = selectedSecondaryConstruct.SecondaryConstructID,
                Name = selectedSecondaryConstruct.Name,
                Money = selectedSecondaryConstruct.Money,
                ActualExpense = selectedSecondaryConstruct.ActualExpense,
                Surplus = selectedSecondaryConstruct.Surplus,
                TopConstructID = selectedTopConstruct.TopConstructID,
                Remark = selectedSecondaryConstruct.Remark
            };

            await secondaryService.UpdateSecondaryConstructAsync(secondary);
            await Refresh();
        }

        public async Task DeleteSecondaryConstructAsync()
        {
            if (selectedSecondaryConstruct == null)
                return;
            await secondaryService.DeleteSecondaryConstructAsync(selectedSecondaryConstruct.SecondaryConstructID);
            await Refresh();
        }

        public async Task SetUpdateInfoAsync()
        {
            Departments = new ObservableCollection<Department>(await depService.QueryDepartments(string.Empty));
            if (selectedSecondaryConstruct == null)
            {
                Budgets = new ObservableCollection<Budget>();
                TopConstructs = new ObservableCollection<TopConstructCategory>();
                SelectedBudget = null;
                SelectedDepartment = null;
                SelectedTopConstruct = null;
            }
            else
            {
                Budgets = new ObservableCollection<Budget>(await budgetService.QueryBudgetByDepID(selectedSecondaryConstruct.DepartmentID));
                TopConstructs = new ObservableCollection<TopConstructCategory>(await topService.QueryTopConstructs(selectedSecondaryConstruct.BudgetID));
                SelectedBudget = Budgets.FirstOrDefault(x => x.BudgetID.Equals(selectedSecondaryConstruct.BudgetID));
                SelectedDepartment = Departments.FirstOrDefault(x => x.DepartmentID.Equals(selectedSecondaryConstruct.DepartmentID));
                SelectedTopConstruct = TopConstructs.FirstOrDefault(x => x.TopConstructID.Equals(selectedSecondaryConstruct.TopConstructID));
            }
        }

        public async Task SetBudgetsAsync()
        {
            if (selectedDepartment != null)
            {
                Budgets = new ObservableCollection<Budget>(await budgetService.QueryBudgetByDepID(selectedDepartment.DepartmentID));
            }
        }

        public async Task SetTopConstructsAsync()
        {
            if(selectedBudget != null)
            {
                TopConstructs = new ObservableCollection<TopConstructCategory>(await topService.QueryTopConstructs(selectedBudget.BudgetID));
            }
        }
    }
}
