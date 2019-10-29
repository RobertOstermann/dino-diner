/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;

        private SodasaurusFlavor flavor;

        private Brush buttonColor = Brushes.SpringGreen;
        /// <summary>
        /// Initialize the FlavorSelection page.
        /// </summary>
        /// <param name="drink"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
            flavor = soda.Flavor;
            SetUpFlavorSelection();
        }

        /// <summary>
        /// Adds the drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            soda.Flavor = flavor;
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Returns to the drink selection page.
        /// Does not change the flavor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Sets the flavor to cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCherry(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            CherryButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Cherry;
        }
        /// <summary>
        /// Sets the flavor to chocolate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectChocolate(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            ChocolateButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Chocolate;
        }
        /// <summary>
        /// Sets the flavor to cola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCola(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            ColaButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Cola;
        }
        /// <summary>
        /// Sets the flavor to lime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLime(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            LimeButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Lime;
        }
        /// <summary>
        /// Sets the flavor to orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectOrange(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            OrangeButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Orange;
        }
        /// <summary>
        /// Sets the flavor to root beer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            RootBeerButton.Background = buttonColor;
            flavor = SodasaurusFlavor.RootBeer;
        }
        /// <summary>
        /// Sets the flavor to cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVanilla(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            VanillaButton.Background = buttonColor;
            flavor = SodasaurusFlavor.Vanilla;
        }
        /// <summary>
        /// Prepares the FlavorSelection user interface.
        /// </summary>
        private void SetUpFlavorSelection()
        {
            ClearButtonValues();
            if (flavor == SodasaurusFlavor.Cherry) CherryButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.Chocolate) ChocolateButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.Cola) ColaButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.Lime) LimeButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.Orange) OrangeButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.RootBeer) RootBeerButton.Background = buttonColor;
            if (flavor == SodasaurusFlavor.Vanilla) VanillaButton.Background = buttonColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            CherryButton.ClearValue(Control.BackgroundProperty);
            ChocolateButton.ClearValue(Control.BackgroundProperty);
            ColaButton.ClearValue(Control.BackgroundProperty);
            LimeButton.ClearValue(Control.BackgroundProperty);
            OrangeButton.ClearValue(Control.BackgroundProperty);
            RootBeerButton.ClearValue(Control.BackgroundProperty);
            VanillaButton.ClearValue(Control.BackgroundProperty);
        }
    }
}
