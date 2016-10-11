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

namespace Laborator1.Tema
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

        private void Calcul()
        {
            int index = operatorCb.SelectedIndex;
            double val1 = val1UD.Value;
            double val2 = val2UD.Value;

            switch(index)
            {
                case 0:
                    DisplayValue(val1 + val2);
                    break;
                case 1:
                    DisplayValue(val1 - val2);
                    break;
                case 2:
                    DisplayValue(val1 * val2);
                    break;
                case 3:
                    {
                        double result = 0;
                        try
                        {
                            result = val1 / val2;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Exception", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        }
                        DisplayValue(result);
                    }
                    break;
            }
        }
        private void DisplayValue(double value)
        {
            ResultLbl.Content = $"Rezultat: {value}";
        }

        private void CalculBtn_Click(object sender, RoutedEventArgs e)
        {
            Calcul();
        }
    }
}
