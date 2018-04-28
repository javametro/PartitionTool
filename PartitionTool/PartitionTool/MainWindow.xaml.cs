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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PartitionTool
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        private int clickedCount = 0;

        public MainWindow()
        {
            InitializeComponent();

            //
            // Get Drives status
            //
            //GetDrives();

        }

        public void GetDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if(d.DriveType == (DriveType)3)
                {
                    MessageBox.Show(d.Name);
                }
                
            }
        }

        private void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Resources["TextBlockLabel"] = string.Format("Clicked {0} time(s)",
            ++clickedCount);
        }
    }
}
