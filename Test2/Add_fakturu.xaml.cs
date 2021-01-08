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
    /// Interakční logika pro Add_fakturu.xaml
    /// </summary>
    public partial class Add_fakturu : Window
    {
        DatabaseEntities3 _db = new DatabaseEntities3();
        DatabaseEntities3 _dbItems = new DatabaseEntities3();


        public Add_fakturu()
        {
            InitializeComponent();

            Datagrid_Companies_Select.ItemsSource = _db.Companies.ToList();

            LoadData();

        }

        private void LoadData()
        {
            Datagrid_Items.ItemsSource = _db.Items.ToList();
        }
        private void Invoice_Add_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Item_Click(object sender, RoutedEventArgs e)
        {
            Items items = new Items()
            {
                Item_Name = Item_name_txtbox.Text,
                Price = int.Parse(Item_price_txtbox.Text),
                amount = int.Parse(Item_amount_txtbox.Text)


            };
            _dbItems.Items.Add(items);
            _dbItems.SaveChanges();
            LoadData();
        }
    }
}
