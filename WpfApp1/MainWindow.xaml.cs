using System.Diagnostics;
using System.Text;
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

        private void opinia_Click(object sender, RoutedEventArgs e)
        {
            string imie_ = imie.Text;
            string nazwisko_ = nazwisko.Text;
            string plec_ = "";

            if (k.IsChecked == true)
            {
                plec_ = "Kobieta";
            }
            else if (m.IsChecked == true)
            {
                plec_ = "Mężczyzna";
            }
            else
            {
                plec_ = "Inna";
            }

            var item = combobox.SelectedItem;
            
            bool isChecked;
            if (isChecked = tak.IsChecked == true)
            {
                opiniaVisibility.Visibility = Visibility.Visible;
            }
            else
            {
                opiniaVisibility.Visibility = Visibility.Hidden;
            }

            string opinia_Klienta = opiniaKlienta.Text;

            int sliderValue_ = (int)sliderValue.Value;
            Debug.WriteLine("Slider Value: " + sliderValue_);

            MessageBox.Show("Opinia osoby: " + imie_ + " " + nazwisko_ + "; Płeć: " + plec_ + "; Model: " + item +"; Wystawiona ocena: "+ sliderValue_ +"; Opinia klienta: "+ opinia_Klienta);
        }

        private void tak_Checked(object sender, RoutedEventArgs e)
        {
            opiniaVisibility.Visibility = tak.IsChecked == true ? Visibility.Visible : Visibility.Hidden;
        }
    }
}