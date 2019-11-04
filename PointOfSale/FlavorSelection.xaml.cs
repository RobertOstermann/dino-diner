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
        /// Confirms the flavor selection.
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
            flavor = SodasaurusFlavor.Cherry;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to chocolate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectChocolate(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.Chocolate;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to cola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCola(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.Cola;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to lime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLime(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.Lime;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectOrange(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.Orange;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to root beer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.RootBeer;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Sets the flavor to cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVanilla(object sender, RoutedEventArgs args)
        {
            flavor = SodasaurusFlavor.Vanilla;
            SetUpFlavorSelection();
        }
        /// <summary>
        /// Prepares the FlavorSelection user interface.
        /// </summary>
        private void SetUpFlavorSelection()
        {
            ClearButtonValues();
            if (flavor == SodasaurusFlavor.Cherry) CherryButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.Chocolate) ChocolateButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.Cola) ColaButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.Lime) LimeButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.Orange) OrangeButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.RootBeer) RootBeerButton.Background = UserInterfaceOptions.SelectedColor;
            if (flavor == SodasaurusFlavor.Vanilla) VanillaButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            CherryButton.Background = UserInterfaceOptions.BaseColor;
            ChocolateButton.Background = UserInterfaceOptions.BaseColor;
            ColaButton.Background = UserInterfaceOptions.BaseColor;
            LimeButton.Background = UserInterfaceOptions.BaseColor;
            OrangeButton.Background = UserInterfaceOptions.BaseColor;
            RootBeerButton.Background = UserInterfaceOptions.BaseColor;
            VanillaButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
