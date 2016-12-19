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

namespace BootstrapWpfStyle
{
    /// <summary>
    /// Win_InputGroup.xaml 的交互逻辑
    /// </summary>
    public partial class Win_InputGroup : Window
    {
        public Win_InputGroup()
        {
            InitializeComponent();
        }

        private void InputGroupButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((TextBox)sender).Text);
        }
    }
}
