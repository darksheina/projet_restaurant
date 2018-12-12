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
            List<HeadWaiter> roleBuisinesses = new List<HeadWaiter>();
            HeadWaiter headwait = new HeadWaiter();
            headwait.RankAssign = 2;
            headwait.SquareAssign = 4;
            headwait.isBusy = true;
            HeadWaiter headwait2 = new HeadWaiter();
            headwait2.RankAssign = 4;
            headwait2.SquareAssign = 2;
            headwait2.isBusy = false;


            roleBuisinesses.Add(headwait);
            roleBuisinesses.Add(headwait2);
            RestaurantActor.ItemsSource = roleBuisinesses;
        }
    }
}
