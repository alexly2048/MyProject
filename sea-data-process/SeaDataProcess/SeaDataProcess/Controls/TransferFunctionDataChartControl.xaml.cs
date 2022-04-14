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
using MahApps.Metro.Controls;
using SeaDataProcess.Views;

namespace SeaDataProcess.Controls
{
    /// <summary>
    /// Interaction logic for TransferFunctionDataChartControl.xaml
    /// </summary>
    public partial class TransferFunctionDataChartControl : MetroContentControl
    {
        public TransferFunctionDataChartControl()
        {
            InitializeComponent();
        }

        public TransferFunctionDataChartControl(TransferFunctionDataChartControlView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private TransferFunctionDataChartControlView view;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = view;
           
        }
    }
}
