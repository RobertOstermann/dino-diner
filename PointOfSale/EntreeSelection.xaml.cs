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
        /// <summary>
        /// Initialize the EntreeSelection page.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
            SetUpEntreeSelection();
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
            if (entree is Brontowurst brontowurst)
            {
                NavigationService.Navigate(new BrontowurstSelection(brontowurst));
            }
            else
            {
                entree = new Brontowurst();
                SetUpEntreeSelection();
                NavigationService.Navigate(new BrontowurstSelection((Brontowurst)entree));
            }
        }

        /// <summary>
        /// Selects dino-nuggets as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (entree is DinoNuggets dinoNuggets)
            {
                NavigationService.Navigate(new DinoNuggetsSelection(dinoNuggets));
            }
            else
            {
                entree = new DinoNuggets();
                SetUpEntreeSelection();
                NavigationService.Navigate(new DinoNuggetsSelection((DinoNuggets)entree));
            }
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
                BrontowurstButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                BrontowurstButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (entree is DinoNuggets)
            {
                AddToOrderButton.IsEnabled = true;
                DinoNuggetsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                DinoNuggetsButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            if (entree is PrehistoricPBJ)
            {
                AddToOrderButton.IsEnabled = true;
                PrehistoricPBJButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                PrehistoricPBJButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            if (entree is PterodactylWings)
            {
                AddToOrderButton.IsEnabled = true;
                PterodactylWingsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                PterodactylWingsButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            if (entree is SteakosaurusBurger)
            {
                AddToOrderButton.IsEnabled = true;
                SteakosaurusBurgerButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                SteakosaurusBurgerButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            if (entree is TRexKingBurger)
            {
                AddToOrderButton.IsEnabled = true;
                TRexKingburgerButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                TRexKingburgerButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            if (entree is VelociWrap)
            {
                AddToOrderButton.IsEnabled = true;
                VelociWrapButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                VelociWrapButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            BrontowurstButton.BorderBrush = UserInterfaceOptions.BaseColor;
            BrontowurstButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            DinoNuggetsButton.BorderBrush = UserInterfaceOptions.BaseColor;
            DinoNuggetsButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            PrehistoricPBJButton.BorderBrush = UserInterfaceOptions.BaseColor;
            PrehistoricPBJButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            PterodactylWingsButton.BorderBrush = UserInterfaceOptions.BaseColor;
            PterodactylWingsButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            SteakosaurusBurgerButton.BorderBrush = UserInterfaceOptions.BaseColor;
            SteakosaurusBurgerButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            TRexKingburgerButton.BorderBrush = UserInterfaceOptions.BaseColor;
            TRexKingburgerButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            VelociWrapButton.BorderBrush = UserInterfaceOptions.BaseColor;
            VelociWrapButton.BorderThickness = UserInterfaceOptions.BaseThickness;
        }
    }
}
