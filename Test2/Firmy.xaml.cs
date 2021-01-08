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
    /// Interakční logika pro Firmy.xaml
    /// </summary>
    public partial class Firmy : Window
    {
        DatabaseEntities3 _db = new DatabaseEntities3();
        public Firmy()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            Datagrid_Companies.ItemsSource = _db.Companies.ToList();
        }

        private void Companies_save_btn(object sender, RoutedEventArgs e)
        {
            Companies companies = new Companies()
            {
                Name = Companies_Name_txtbox.Text,
                Street = Companies_Street_txtbox.Text,
                City = Companies_city_txtbox.Text,
                Ico = Companies_txt_Ico.Text,
                Dico = Companies_Dico_txt.Text

            };
            _db.Companies.Add(companies);
            _db.SaveChanges();
            LoadData();
        }

        private void Companies_delete_button(object sender, RoutedEventArgs e)
        {
            int Id = (Datagrid_Companies.SelectedItem as Companies).id;
            var deletecompany = _db.Companies.Where(c => c.id == Id).Single();
            _db.Companies.Remove(deletecompany);


            _db.SaveChanges();
            LoadData();
        }
    }
}
