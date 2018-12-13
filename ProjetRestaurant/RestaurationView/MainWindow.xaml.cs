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
using ProjetLibrary.Business.RestaurantDinerRoom.DinerRoom;

namespace RestaurationView
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<CustomerGroup> listGr = new List<CustomerGroup>
            {
                new CustomerGroup { Name = "group1", GroupNumber = 1, IDTable = 5 },
                new CustomerGroup { Name= "group2", GroupNumber = 2, IDTable =5}
            };

            
             
            

            
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();

        }
    }
}
