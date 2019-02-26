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

namespace _185909IPO
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

        private void HideVisibleText()
        {
            if (Cpu.Visibility == Visibility.Visible)
            {
                Cpu.Visibility = Visibility.Hidden;
            }

            if (CpuCooler.Visibility == Visibility.Visible)
            {
                CpuCooler.Visibility = Visibility.Hidden;
            }

            if (MotherBoard.Visibility == Visibility.Visible)
            {
                MotherBoard.Visibility = Visibility.Hidden;
            }

            if (Memory.Visibility == Visibility.Visible)
            {
                Memory.Visibility = Visibility.Hidden;
            }

            if (Storage.Visibility == Visibility.Visible)
            {
                Storage.Visibility = Visibility.Hidden;

            }
            if (VideoCard.Visibility == Visibility.Visible)
            {
                VideoCard.Visibility = Visibility.Hidden;
            }
                    
                    
                    
        }


        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            Cpu.Visibility = Visibility.Visible;

        }

        private void BtnClick_Click2(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            CpuCooler.Visibility = Visibility.Visible;
        }
        private void BtnClick_Click3(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            MotherBoard.Visibility = Visibility.Visible;
        }
        private void BtnClick_Click4(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            Memory.Visibility = Visibility.Visible;
        }
        private void BtnClick_Click5(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            Storage.Visibility = Visibility.Visible;
        }
        private void BtnClick_Click6(object sender, RoutedEventArgs e)
        {
            HideVisibleText();
            VideoCard.Visibility = Visibility.Visible;
        }
        private void BtnClick_Click7(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click8(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click9(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click10(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click11(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click12(object sender, RoutedEventArgs e)
        {
        }
        private void BtnClick_Click13(object sender, RoutedEventArgs e)
        {
        }
    }
}
