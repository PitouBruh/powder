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

namespace powder
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            int[] lvl=new int[62] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 20, 22, 22, 24, 24, 26, 26, 28, 28, 30,0 };
            int[] gold = new int[62] { 0, 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000, 2600, 3200, 3800, 4400, 5000, 5600, 6200, 6800, 7400, 8000, 8600, 9200, 9800, 10400, 11000, 11600, 12200, 12800, 13400, 14000, 15600, 17200, 18800, 20400, 22000, 23600, 25200, 26800, 28400, 32000, 34000, 36000, 38000, 40000, 42000, 44000, 46000, 48000, 50000,0 };
            int goldc = 0;
            int i;
            Int32.TryParse(from.Text, out i);
            i += 1;
            int j;
            Int32.TryParse(target.Text, out j);
            int normal = 0;
            int refined = 0;
            int pristine = 0;
            while (i <= j)
            {
                if (i >= 1 && i <= 20)
                {
                    normal += lvl[i];
                }
                else if (i > 20 && i <= 40)
                {
                    refined += lvl[i];
                }
                else if (i > 40 && i <= 60)
                {
                    pristine += lvl[i];
                }
                goldc += gold[i];
                i++;
            }
            string total = ("Normal: " + normal + "\nRefined: " + refined + "\nPristine: " + pristine + "\nCoin: " + goldc);
            Total.Text = total;

        }
    }
}
