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

namespace TestNewDesign.View.MainWindowSystem
{
    /// <summary>
    /// Логика взаимодействия для WIMOMainWindow.xaml
    /// </summary>
    public partial class WIMOMainWindow : Window
    {
        public WIMOMainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel.WIMOMainWindowViewModel.WIMOMainWindowSystemViewModel();

            ViewModel.WIMOMainWindowViewModel.WIMOMainWindowSystemViewModel.CloseWindowMain = new Action(() => this.Close());
        }
    }
}
