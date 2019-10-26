/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;

        private Brush buttonColor = Brushes.LightGreen;

        private Thickness buttonBorderThickness = new Thickness(2.5);

        public EntreeSelection()
        {
            InitializeComponent();
            AddToOrderButton.IsEnabled = false;
        }

        /// <summary>
        /// Adds the entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectAddToOrder(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Returns to the category selection page.
        /// Does not add the entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            entree = new Brontowurst();
            EnableButtons();
            ClearButtonValues();
            BrontowurstButton.BorderBrush = buttonColor;
            BrontowurstButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            entree = new DinoNuggets();
            EnableButtons();
            ClearButtonValues();
            DinoNuggetsButton.BorderBrush = buttonColor;
            DinoNuggetsButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            entree = new PrehistoricPBJ();
            EnableButtons();
            ClearButtonValues();
            PrehistoricPBJButton.BorderBrush = buttonColor;
            PrehistoricPBJButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            entree = new PterodactylWings();
            EnableButtons();
            ClearButtonValues();
            PterodactylWingsButton.BorderBrush = buttonColor;
            PterodactylWingsButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            entree = new SteakosaurusBurger();
            EnableButtons();
            ClearButtonValues();
            SteakosaurusBurgerButton.BorderBrush = buttonColor;
            SteakosaurusBurgerButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingburger(object sender, RoutedEventArgs args)
        {
            entree = new TRexKingBurger();
            EnableButtons();
            ClearButtonValues();
            TRexKingburgerButton.BorderBrush = buttonColor;
            TRexKingburgerButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            entree = new VelociWrap();
            EnableButtons();
            ClearButtonValues();
            VelociWrapButton.BorderBrush = buttonColor;
            VelociWrapButton.BorderThickness = buttonBorderThickness;
        }

        private void ClearButtonValues()
        {
            BrontowurstButton.ClearValue(Control.BorderBrushProperty);
            BrontowurstButton.ClearValue(Control.BorderThicknessProperty);
            DinoNuggetsButton.ClearValue(Control.BorderBrushProperty);
            DinoNuggetsButton.ClearValue(Control.BorderThicknessProperty);
            PrehistoricPBJButton.ClearValue(Control.BorderBrushProperty);
            PrehistoricPBJButton.ClearValue(Control.BorderThicknessProperty);
            PterodactylWingsButton.ClearValue(Control.BorderBrushProperty);
            PterodactylWingsButton.ClearValue(Control.BorderThicknessProperty);
            SteakosaurusBurgerButton.ClearValue(Control.BorderBrushProperty);
            SteakosaurusBurgerButton.ClearValue(Control.BorderThicknessProperty);
            TRexKingburgerButton.ClearValue(Control.BorderBrushProperty);
            TRexKingburgerButton.ClearValue(Control.BorderThicknessProperty);
            VelociWrapButton.ClearValue(Control.BorderBrushProperty);
            VelociWrapButton.ClearValue(Control.BorderThicknessProperty);
        }

        private void EnableButtons()
        {
            AddToOrderButton.IsEnabled = true;
        }
    }
}
