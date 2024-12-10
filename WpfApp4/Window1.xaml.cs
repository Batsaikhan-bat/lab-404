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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Students student { get; set; }    
        public Window1()
        {
            InitializeComponent();
        }
        public void UpdateUI()
        {
            if (student != null)
            {
                bt_id.Text = student.ID;
                bt_name.Text = student.Name;
                bt_au.Text =student.Author;
                bt_des.Text = student.Description;
            }
        }

        private void bt_ADD_Click(object sender, RoutedEventArgs e)
        {
            
                this.DialogResult = true;
                student.Name = bt_name.Text;
                student.ID = bt_id.Text;
                student.Author = bt_au.Text;
                student.Description = bt_des.Text;
            this.Close();
            
        }

        private void bt_CANCEL_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
