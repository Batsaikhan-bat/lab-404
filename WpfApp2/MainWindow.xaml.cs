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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Fruit> fruitList = new List<Fruit>();
        
        public MainWindow()
        {
            InitializeComponent();
            lv_main.ItemsSource= fruitList;
        }

        private void bt_01_Click(object sender, RoutedEventArgs e)
        {
            if (this.OwnedWindows.Count == 0)
            {
                SecWindow secWindow = new SecWindow();
                secWindow.Owner = this;
                secWindow.main = this;
                secWindow.Show();
            }
            

        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            FruitWindow fruitWindow = new FruitWindow();   
            fruitWindow.fruit = new Fruit();
            if(fruitWindow.ShowDialog()==true)
            {
                fruitList.Add(fruitWindow.fruit);
                lv_main.ItemsSource = null;
                lv_main.ItemsSource = fruitList;
            }
        }

        private void bt_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lv_main.SelectedItem !=null)
            { 
                FruitWindow fruitWindow = new FruitWindow();
                 fruitWindow.fruit = lv_main.SelectedItem as Fruit;
                fruitWindow.UpdateUI();

                if (fruitWindow.ShowDialog() == true)
                {
                    
                    lv_main.ItemsSource = null;
                    lv_main.ItemsSource = fruitList;
                }

            }
            
        }

        private void bt_Delete_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Are you sure?");
            MessageBoxButton btnDelete = MessageBoxButton.YesNo;    
            if (lv_main.SelectedItem != null )
            {
                FruitWindow fruitWindow = new FruitWindow();
                fruitWindow.fruit = lv_main.SelectedItem as Fruit;
               
                
                

            }

        }
    }
}
