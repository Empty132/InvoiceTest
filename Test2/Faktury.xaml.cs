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

namespace Test2
{
    /// <summary>
    /// Interakční logika pro Faktury.xaml
    /// </summary>
    public partial class Faktury : Window
    {
        DatabaseEntities3 _db = new DatabaseEntities3();
        public Faktury()
        {
            InitializeComponent();

            Invoices_GridData.ItemsSource = _db.Invoices.ToList();
        }
    }
}
