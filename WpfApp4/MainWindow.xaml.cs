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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Students> sList = new List<Students>();
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.student = new Students();
            if (window.ShowDialog() == true)
            {
                sList.Add(window.student);
                lv_main.ItemsSource = null;
                lv_main.ItemsSource = sList;
            }
        }

        private void bt_Edit_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.student = new Students();
            if (window.ShowDialog() == true)
            {
                sList.Add(window.student);
                lv_main.ItemsSource = null;
                lv_main.ItemsSource = sList;
            }
        }

        private void bt_Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_01_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_02_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
