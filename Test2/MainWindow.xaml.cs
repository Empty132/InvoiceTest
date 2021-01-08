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

namespace Test2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Companies_btn(object sender, RoutedEventArgs e)
        {
            Firmy window = new Firmy();
            window.Show();

            Close();

        }

        private void Invoices_btn(object sender, RoutedEventArgs e)
        {
            Faktury faktury = new Faktury();
            faktury.Show();

            Close();
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Invoice_btn(object sender, RoutedEventArgs e)
        {
            Add_fakturu add = new Add_fakturu();
            add.Show();
            Close();
        }
    }
}
