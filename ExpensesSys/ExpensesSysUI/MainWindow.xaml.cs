using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExpensesSysLib.Helper;
using ExpensesSysUI.Controls;
using MahApps.Metro.Controls;

namespace ExpensesSysUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Dictionary<string, MetroContentControl> controls = new Dictionary<string, MetroContentControl>();
        private Dictionary<string, string> titles = new Dictionary<string, string>();
        private async void mainMenu_ItemInvoked(object sender, ItemClickEventArgs args)
        {
            var item = (args.ClickedItem as HamburgerMenuGlyphItem).Tag.ToString();
            if (controls.ContainsKey(item))
            {
                mainMenu.Content = controls[item];
                this.Title = titles[item];
            }
            else
            {
                await DialogHelper.ShowAffirmative("该菜单功能未实现，请联系开发人员");
            }
        }

        private void MainWindow_Load(object sender, RoutedEventArgs e)
        {
            DBHelper.CreateTables();
            controls.Add("Department", new DepartmentControl());
            titles.Add("Department", "部门信息");
            controls.Add("Office", new AdministrativeOfficeControl());
            titles.Add("Office", "科室信息");
            controls.Add("Budget", new BudgetControl());
            titles.Add("Budget", "预算科目");
            controls.Add("TopConstruct", new TopConstructControl());
            titles.Add("TopConstruct", "一级项目类别");
            controls.Add("SecondaryConstruct", new SecondaryConstructControl());
            titles.Add("SecondaryConstruct", "二级项目类别");
            controls.Add("Construct", new ConstructControl());
            titles.Add("Construct", "项目");
            controls.Add("ConstructItem", new ConstructItemControl());
            titles.Add("ConstructItem", "开支明细");
        }
    }
}
