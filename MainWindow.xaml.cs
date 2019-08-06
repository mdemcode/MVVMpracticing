using System.Windows;
using MVVMtest.Widok;

namespace MVVMtest {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Testowy2_Click(object sender, RoutedEventArgs e)
        {
            WidokTestowy okno = new WidokTestowy();
            okno.ShowDialog();
        }
    }
}
