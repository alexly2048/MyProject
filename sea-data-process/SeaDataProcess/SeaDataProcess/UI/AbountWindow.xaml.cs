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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace SeaDataProcess.UI
{
    /// <summary>
    /// Interaction logic for AbountWindow.xaml
    /// </summary>
    public partial class AbountWindow : MetroWindow
    {
        public AbountWindow()
        {
            InitializeComponent();
        }

        private void AboutWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Resources/background.jpg"));
            brush.Opacity = 0.8;
            this.Background = brush;
            */
        }
    }
}
