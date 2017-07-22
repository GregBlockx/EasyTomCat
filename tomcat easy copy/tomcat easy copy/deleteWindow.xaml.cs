using System;
using System.Collections.Generic;
using System.IO;
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

namespace tomcat_easy_copy
{
    /// <summary>
    /// Interaction logic for deleteWindow.xaml
    /// </summary>
    public partial class deleteWindow : Window
    {
        private string path = @"C:\xampp\tomcat\webapps";
        public deleteWindow()
        {
            InitializeComponent();


            List<string> directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).ToList();
            foreach (var dir in directories)
            {
                FoldercomboBox.Items.Add(dir);
            }

            List<string> files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).ToList();
            foreach (var file in files)
            {
                WarFilecomboBox.Items.Add(file);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.Directory.Exists(FoldercomboBox.Text) && System.IO.File.Exists(WarFilecomboBox.Text))
            {
                try
                {
                    System.IO.Directory.Delete(FoldercomboBox.Text, true);
                    System.IO.File.Delete(WarFilecomboBox.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MenuItemFile_Click(object sender, RoutedEventArgs e)
        {
            copyWindow cw = new copyWindow();
            cw.Show();
            this.Close();
        }
    }
}
