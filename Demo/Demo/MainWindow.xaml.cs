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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this is another place.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("呵呵呵，我在服务器上修改了代码");
            MessageBox.Show("这是我在branch-my-pc下修改的");
            MessageBox.Show("在branch-my-pc下再次进行了修改的");
        }
    }
}
