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
    /// Interaction logic for copyWindow.xaml
    /// </summary>
    public partial class copyWindow : Window
    {
        private string sourcePath = @"C:\Users\greg\IdeaProjects";
        private string targetPath = @"C:\xampp\tomcat\webapps";
        private string warFileName;

        public copyWindow()
        {
            InitializeComponent();

            List<string> directories = Directory.GetDirectories(sourcePath, "*", SearchOption.TopDirectoryOnly).ToList();

            foreach (var dir in directories)
            {
                ProjectcomboBox.Items.Add(dir);
            }
        }

        private void copyButton_Click(object sender, RoutedEventArgs e)
        {
            warFileName = warFileNameTextbox.Text + ".war";
            sourcePath = ProjectcomboBox.Text;

            string sourceWarFile = addToPath(sourcePath + @"\target\", warFileName);
            string destWarFile = addToPath(targetPath, warFileName);

            try
            {
                System.IO.File.Copy(sourceWarFile, destWarFile, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string addToPath(string path, string add)
        {
            string newPath = System.IO.Path.Combine(path, add);

            return newPath;
        }

        private void MenuItemView_Click(object sender, RoutedEventArgs e)
        {
            deleteWindow dw = new deleteWindow();
            dw.Show();
            this.Close();
        }
    }
}
