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
    public class BudgetView : BaseEntity
    {
        public BudgetView()
        {
            budgetService = new BudgetService();
            depService = new DepartmentService();
        }
        private readonly BudgetService budgetService;
        private readonly DepartmentService depService;
        private ObservableCollection<BudgetViewModel> budgets;
        private BudgetViewModel selectedBudget;
        private ObservableCollection<Department> departments;
        private Department selectedDepartment;
        private Budget addBudget;
        private string key;

        public ObservableCollection<BudgetViewModel> Budgets
        {
            get { return budgets; }
            set { budgets = value; RaisePropertyChanged(); }
        }
        public BudgetViewModel SelectedBudget
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
        public Budget AddBudget
        {
            get { return addBudget; }
            set 
            { addBudget = value;
              addBudget.Surplus = addBudget.Money - addBudget.ActualExpense;
              RaisePropertyChanged(); 
            }
        }
        public string Key
        {
            get { return key; }
            set { key = value; RaisePropertyChanged(); }
        }

        // methods
        public async Task Refresh()
        {
            Budgets = new ObservableCollection<BudgetViewModel>(await budgetService.QueryBudgetViews(Key));
        }

        public async Task AddBudgetAsync()
        {
            if (addBudget == null)
                return;
            if (selectedDepartment == null)
                return;

            addBudget.DepartmentID = selectedDepartment.DepartmentID;
            await budgetService.AddBudgetAsync(AddBudget);
            await Refresh();
        }

        public async Task UpdateBudgetAsync()
        {
            if (selectedBudget == null)
                return;
            if (selectedDepartment == null)
                return;
            var budget = new Budget
            {
                BudgetID = selectedBudget.BudgetID,
                Name = selectedBudget.Name,
                Money = selectedBudget.Money,
                Surplus = selectedBudget.Surplus,
                ActualExpense = selectedBudget.ActualExpense,
                DepartmentID = selectedDepartment.DepartmentID,
                Remark = selectedBudget.Remark
            };

            await budgetService.UpdateBudgetAsync(budget);
            await Refresh();
        }

        public async Task DeleteBudgetAsync()
        {
            if(SelectedBudget == null)
            {
                await DialogHelper.ShowAffirmative("请选择要删除的数据");
                return;
            }

            await budgetService.DeleteBudgetAsync(selectedBudget.BudgetID);
            await Refresh();
        }

        public async Task SetDepartments()
        {
            Departments = new ObservableCollection<Department>(await depService.QueryDepartments(string.Empty));
            if (SelectedBudget == null)
                SelectedDepartment = null;
            else
                SelectedDepartment = Departments.FirstOrDefault(x => x.DepartmentID.Equals(selectedBudget.DepartmentID));
        }
    }
}
