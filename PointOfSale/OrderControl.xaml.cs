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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Edits the selected order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void EditItem(object sender, MouseButtonEventArgs args)
        {
            //TODO: Allow user to edit all items. Add this code to the OrderControl UI.
            if (OrderList.SelectedItem is Side side)
            {
                //Pass in side.
                //NavigationService?.Navigate(new SideSelection(side));
            }
        }
        /// <summary>
        /// Removes the selected order item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                        order.Items.Remove(item);
                }
            }
        }
    }
}
