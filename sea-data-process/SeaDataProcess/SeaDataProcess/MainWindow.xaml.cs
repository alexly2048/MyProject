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
using MahApps.Metro;
using MahApps.Metro.Controls;
using SeaDataProcess.Controls;
using SeaDataProcess.UI;
using SeaDataProcess.Views;

namespace SeaDataProcess
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
        private readonly GlobalParamView globalParam = new GlobalParamView();
        private async void mainMenu_ItemInvoked(object sender, ItemClickEventArgs args)
        {
            var item = (args.ClickedItem as HamburgerMenuGlyphItem).Tag.ToString();
            if (item.Equals("SelectSpectrumParam"))
            {
                var settingWindow = new SelectSpectrumTypeWindow();
                settingWindow.Owner = this;
                settingWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                settingWindow.ShowDialog();

                args.Handled = true;
            }
            else if (item.Equals("About"))
            {
                var about = new AbountWindow();
                about.Owner = this;
                about.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                about.ShowDialog();

                args.Handled = true;
            }
            else if (item.Equals("HelpDoc"))
            {
                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "help.pdf");
                if (!System.IO.File.Exists(file))
                {
                    await DialogHelper.ShowAffirmative("帮助文件丢失，请联系开始人员");
                    return;
                }
                System.Diagnostics.Process.Start(file);
                args.Handled = true;
            }
            else
            {
                if (controls.ContainsKey(item))
                {
                    mainMenu.Content = controls[item];
                }
                else
                {
                    await DialogHelper.ShowAffirmative("该菜单功能未实现，请联系开发人员");
                }

                args.Handled = true;
            }
        }

        private void MainWindow_Load(object sender, RoutedEventArgs e)
        {
            controls.Add("DataProcess", new DataProcessControl());
            controls.Add("TransferFunction", new LoadTransferFunctionControl());

            globalParam.InitialDatas(); // when load window, initial direction probability datas from json.

            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Resources/background.jpg"));
            brush.Opacity = 0.8;
            this.Background = brush;
        }
    }
}
