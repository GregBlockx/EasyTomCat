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

namespace tomcat_easy_copy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemFile_Click(object sender, RoutedEventArgs e)
        {
            copyWindow cw = new copyWindow();
            cw.Show();
            this.Close();
        }

        private void MenuItemView_Click(object sender, RoutedEventArgs e)
        {
            deleteWindow dw = new deleteWindow();
            dw.Show();
            this.Close();
        }
    }
}
