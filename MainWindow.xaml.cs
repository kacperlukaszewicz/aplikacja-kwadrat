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

namespace WpfApp1
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

        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text, out bok) && bok >= 0)
            {
                txtPole.Text = Math.Pow(bok, 2.0).ToString();
                txtObwod.Text = (bok * 4).ToString();
                lblKomunikat.Content = String.Empty;
            }
            else
            {
                lblKomunikat.Content = "Wpisz liczbę dodatnią";
            }
        }

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            lblKomunikat.Content = "Wpisz wymiar boku";
        }

        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok; //max 380 inaczej sie nie zmiesni ;(
            if (double.TryParse(txtBok.Text, out bok) && bok <=220) {
                rectangle1.Height = bok;
                rectangle1.Width = bok;
                SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(cmbKolor.Text);
                rectangle1.Stroke = color;
                rectangle1.Fill = color;
                rectangle1.Opacity = (cbPrzezroczysty.IsChecked.Value) ? 0.5 : 1;
            } else
            {
                lblKomunikat.Content = "Brak danych lub zbyt duży bok";
            }
        }
    }
}
