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
            if (DataContext is Order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        if (item is Entree entree)
                        {
                            if (entree is Brontowurst brontowurst) NavigationService?.Navigate(new BrontowurstSelection(brontowurst, true));
                            else if (entree is DinoNuggets dinoNuggets) NavigationService?.Navigate(new DinoNuggetsSelection(dinoNuggets, true));
                            else if (entree is PrehistoricPBJ prehistoricPBJ) NavigationService?.Navigate(new PrehistoricPBJSelection(prehistoricPBJ, true));
                            else if (entree is SteakosaurusBurger steakosaurusBurger) NavigationService?.Navigate(new SteakosaurusBurgerSelection(steakosaurusBurger, true));
                            else if (entree is TRexKingBurger kingBurger) NavigationService?.Navigate(new TRexKingBurgerSelection(kingBurger, true));
                            else if (entree is VelociWrap velociWrap) NavigationService?.Navigate(new VelociWrapSelection(velociWrap, true));
                        }
                        else if (item is Drink drink)
                        {
                            NavigationService?.Navigate(new DrinkSelection(drink, true));
                        }
                        else if (item is Side side)
                        {
                            NavigationService?.Navigate(new SideSelection(side, true));
                        }
                        else if (item is CretaceousCombo combo)
                        {
                            NavigationService?.Navigate(new CustomizeCombo(combo, true));
                        }
                    }
                }
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
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
