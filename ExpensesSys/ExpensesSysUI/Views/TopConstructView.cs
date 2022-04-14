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
    public class TopConstructView:BaseEntity
    {
        public TopConstructView()
        {
            budgetService = new BudgetService();
            depService = new DepartmentService();
            topService = new TopConstructService();
        }
        private readonly TopConstructService topService;
        private readonly BudgetService budgetService;
        private readonly DepartmentService depService;
        private ObservableCollection<Budget> budgets;
        private Budget selectedBudget;
        private ObservableCollection<Department> departments;
        private Department selectedDepartment;
        private ObservableCollection<TopConstructViewModel> topConstructs;
        private TopConstructViewModel selectedTopConstruct;
        private TopConstructCategory addTopConstruct;
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

        public ObservableCollection<TopConstructViewModel> TopConstructs
        {
            get { return topConstructs; }
            set { topConstructs = value;RaisePropertyChanged(); }
        }

        public TopConstructViewModel SelectedTopConstruct
        {
            get { return selectedTopConstruct; }
            set { selectedTopConstruct = value;RaisePropertyChanged(); }
        }

        public TopConstructCategory AddTopConstruct
        {
            get { return addTopConstruct; }
            set
            {
                addTopConstruct = value;
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
            TopConstructs = new ObservableCollection<TopConstructViewModel>(await topService.QueryTopConstructViews(Key));
        }

        public async Task AddTopConstructAsync()
        {
            if (selectedBudget == null)
                return;
            if (addTopConstruct == null)
                return;

            addTopConstruct.BudgetID = selectedBudget.BudgetID;
            await topService.AddTopConstructCategory(addTopConstruct);
            await Refresh();
        }

        public async Task UpdateTopConstructAsync()
        {
            if (selectedBudget == null)
                return;
            if (selectedTopConstruct == null)
                return;

            var top = new TopConstructCategory
            {
                TopConstructID = selectedTopConstruct.TopConstructID,
                Name = selectedTopConstruct.Name,
                Money = selectedTopConstruct.Money,
                ActualExpense = selectedTopConstruct.ActualExpense,
                Surplus = selectedTopConstruct.Surplus,
                BudgetID = selectedBudget.BudgetID,
                Remark = selectedTopConstruct.Remark
            };

            await topService.UpdateTopConstructCategory(top);
            await Refresh();
        }

        public async Task DeleteTopConstructAsync()
        {
            if (selectedTopConstruct == null)
                return;
            await topService.DeleteTopConstructCategory(selectedTopConstruct.TopConstructID);
            await Refresh();
        }

        public async Task SetDepartmentsAsync()
        {
            Departments = new ObservableCollection<Department>(await depService.QueryDepartments(string.Empty));
            if(selectedTopConstruct == null)
            {
                Budgets = new ObservableCollection<Budget>();
                SelectedBudget = null;
                SelectedDepartment = null;
            }
            else
            {
                Budgets = new ObservableCollection<Budget>(await budgetService.QueryBudgetByDepID(selectedTopConstruct.DepartmentID));
                SelectedDepartment = Departments.FirstOrDefault(x => x.DepartmentID.Equals(selectedTopConstruct.DepartmentID));
                SelectedBudget = Budgets.FirstOrDefault(x => x.BudgetID.Equals(selectedTopConstruct.BudgetID));
            }
        }

        public async Task SetBudgetsAsync()
        {
            if(selectedDepartment != null)
            {
                Budgets = new ObservableCollection<Budget>(await budgetService.QueryBudgetByDepID(selectedDepartment.DepartmentID));
            }
        }
    }
}
