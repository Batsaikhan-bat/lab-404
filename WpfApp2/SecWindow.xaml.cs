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
    /// Interaction logic for SecWindow.xaml
    /// </summary>
    public partial class SecWindow : Window
    {
        public MainWindow main { get; set; } =null;
        public SecWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(main != null)
            {
                main.bt_01.Content = this.sl_sec.Value.ToString("f0");
            }
        }
    }
}
