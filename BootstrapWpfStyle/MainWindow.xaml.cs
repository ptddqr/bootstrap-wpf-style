using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace BootstrapWpfStyle
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Assembly _assembly = Assembly.GetExecutingAssembly();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string winName = ((Button)e.OriginalSource).Tag.ToString();
            Window win = ((Window)_assembly.CreateInstance(string.Format("BootstrapWpfStyle.{0}", winName)));
            win.Owner = this;
            win.Show();
        }
    }
}
