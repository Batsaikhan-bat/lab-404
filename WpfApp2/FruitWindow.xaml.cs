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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for FruitWindow.xaml
    /// </summary>
    public partial class FruitWindow : Window
    {
        public Fruit fruit { get; set; } 
        public FruitWindow()
        {
            InitializeComponent();
        }
        public void UpdateUI()
        {
            if(fruit != null)
            {
                tb_name.Text = fruit.Name;
                tb_color.Text = fruit.Color;
                tb_country.Text = fruit.Country;
            }
        }

        private void bt_ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            fruit.Name= tb_name.Text;
            fruit.Color= tb_color.Text;
            fruit.Country= tb_country.Text;
            this.Close();
        }
    }
}
