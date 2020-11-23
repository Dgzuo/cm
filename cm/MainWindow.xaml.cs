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

namespace cm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fir_Click(object sender, RoutedEventArgs e)
        {
            string[] sArr = fols.Text.Split(',');

            int[,] arr = new int[3, 3];

            int indexS = 0;
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(sArr[indexS]);
                    indexS++;
                }
            }

            string res = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res += " " + arr[i, j];
                }
                res += "\n";
            }

            int stolb = 3 - 1;
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += arr[j, stolb];
            }

            res += "\n sum = " + sum;
            man.Content = res;
        }
    }
}
