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
using System.Windows.Shapes;
using MVVMtest.ModelWidoku;
using MVVMtest.Model;

namespace MVVMtest.Widok
{
    /// <summary>
    /// Interaction logic for WidokTestowy.xaml
    /// </summary>
    public partial class WidokTestowy : Window
    {
        public WidokTestowy()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WidokGlowny widokGlowny = DataContext as WidokGlowny;
            widokGlowny.Zlecenia = 11m; // !!! Nie zmienia wartości ZLECENIA w oknie gównym - (POWIADOMIENIA?) !!!
            Cosik dane1 = new Cosik
            {
                Elementy = widokGlowny.Elementy,
                Grupy = widokGlowny.Grupy,
                Zlecenia = widokGlowny.Zlecenia
            };
            DAL.Zapisz(dane1);
        }
    }
}
