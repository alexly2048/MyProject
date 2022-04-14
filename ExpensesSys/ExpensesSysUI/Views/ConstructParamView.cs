using ExpensesSysLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSysUI.Views
{
    public class ConstructParamView:BaseEntity
    {
        private string budgetName;
        private string topConstructName;
        private string secondaryConstructName;
        private string constructName;
        private DateTime? actualCompletedDateStart;
        private DateTime? actualCompletedDateEnd;
        private string officeName;

        public string BudgetName
        {
            get { return budgetName; }
            set { budgetName = value;RaisePropertyChanged(); }
        }

        public string TopConstructName
        {
            get { return topConstructName; }
            set { topConstructName = value;RaisePropertyChanged(); }
        }

        public string SecondaryConstructName
        {
            get { return secondaryConstructName; }
            set { secondaryConstructName = value;RaisePropertyChanged(); }
        }

        public string ConstructName
        {
            get { return constructName; }
            set { constructName = value;RaisePropertyChanged(); }
        }

        public DateTime? ActualCompletedDateStart
        {
            get { return actualCompletedDateStart; }
            set { actualCompletedDateStart = value;RaisePropertyChanged(); }
        }

        public DateTime? ActualCompletedDateEnd
        {
            get { return actualCompletedDateEnd; }
            set { actualCompletedDateEnd = value; RaisePropertyChanged(); }
        }

        public string OfficeName
        {
            get { return officeName; }
            set { officeName = value;RaisePropertyChanged(); }
        }
    }
}
