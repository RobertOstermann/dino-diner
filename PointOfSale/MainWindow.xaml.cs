/* MainWindow.xaml.cs
 * Author: Robert Ostermann
 */
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
            //Bunch of BS
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.Sweet = true;
            tea.Size = DinoDiner.Menu.Size.Medium;
            order.Items.Add(tea);
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = DinoDiner.Menu.Size.Medium;
            order.Items.Add(mmc);
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            if (OrderInterface.Content is FrameworkElement content)
            {
                content.DataContext = OrderInterface.DataContext;
            }
        }
    }
}
