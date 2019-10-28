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

        private Brush buttonColor = Brushes.SpringGreen;

        private Thickness buttonBorderThickness = new Thickness(2.5);
        /// <summary>
        /// Initialize the EntreeSelection page.
        /// </summary>
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
        /// Selects brontowurst as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            entree = new Brontowurst();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Selects dino-nuggets as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            entree = new DinoNuggets();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Selects prehistoric pb&j as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new PrehistoricPBJSelection(pbj));
            }
            else
            {
                entree = new PrehistoricPBJ();
                SetUpEntreeSelection();
                NavigationService.Navigate(new PrehistoricPBJSelection((PrehistoricPBJ)entree));
            }
        }

        /// <summary>
        /// Selects pterodactyl wings as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            entree = new PterodactylWings();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Selects steakosaurus burger as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            entree = new SteakosaurusBurger();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Selects trex kingburger as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingburger(object sender, RoutedEventArgs args)
        {
            entree = new TRexKingBurger();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Selects veloci wrap as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            entree = new VelociWrap();
            SetUpEntreeSelection();
        }
        /// <summary>
        /// Prepares the EntreeSelection user interface.
        /// </summary>
        private void SetUpEntreeSelection()
        {
            ClearButtonValues();
            if (entree is Brontowurst)
            {
                AddToOrderButton.IsEnabled = true;
                BrontowurstButton.BorderBrush = buttonColor;
                BrontowurstButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is DinoNuggets)
            {
                AddToOrderButton.IsEnabled = true;
                DinoNuggetsButton.BorderBrush = buttonColor;
                DinoNuggetsButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is PrehistoricPBJ)
            {
                AddToOrderButton.IsEnabled = true;
                PrehistoricPBJButton.BorderBrush = buttonColor;
                PrehistoricPBJButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is PterodactylWings)
            {
                AddToOrderButton.IsEnabled = true;
                PterodactylWingsButton.BorderBrush = buttonColor;
                PterodactylWingsButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is SteakosaurusBurger)
            {
                AddToOrderButton.IsEnabled = true;
                SteakosaurusBurgerButton.BorderBrush = buttonColor;
                SteakosaurusBurgerButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is TRexKingBurger)
            {
                AddToOrderButton.IsEnabled = true;
                TRexKingburgerButton.BorderBrush = buttonColor;
                TRexKingburgerButton.BorderThickness = buttonBorderThickness;
            }
            if (entree is VelociWrap)
            {
                AddToOrderButton.IsEnabled = true;
                VelociWrapButton.BorderBrush = buttonColor;
                VelociWrapButton.BorderThickness = buttonBorderThickness;
            }
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
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
    }
}
