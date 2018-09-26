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
        public MainWindow()
        {
            InitializeComponent();
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

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            textBlock.Text = @"「開始」ボタンを押すと「ディスクの管理」が起動します。\n「ディスクの管理」画面でパーティション設定の変更を行ってください。\n変更したいドライブを右クリックし、表示されるメニューから必要な操作を\n選んでください。";
        }
    }
}
