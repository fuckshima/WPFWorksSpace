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

namespace WPFWorksSpace
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new VMMainWindow();
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VMMainWindow vm = DataContext as VMMainWindow;
            if (vm != null)
            {
                vm.DisplayImage = new BitmapImage(new Uri("Images/ライザのアトリエ.jpg", UriKind.Relative));
            }
        }
    }
}
