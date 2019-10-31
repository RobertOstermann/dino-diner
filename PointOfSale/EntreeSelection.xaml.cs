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

        private bool isEdit;

        private bool isCombo;

        private CretaceousCombo combo;
        /// <summary>
        /// Initialize the EntreeSelection page.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
            SetUpEntreeSelection();
            ConfirmButton.IsEnabled = false;
            isCombo = false;
        }
        /// <summary>
        /// Initialize the EntreeSelection page.
        /// Allows user to edit the selected combo.
        /// </summary>
        /// <param name="combo"></param>
        public EntreeSelection(CretaceousCombo combo, bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.combo = combo;
            entree = combo.Entree;
            isCombo = true;
            ConfirmTextBlock.Text = "Confirm";
            SetUpEntreeSelection();
        }
        /// <summary>
        /// Adds the entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                combo.Entree = entree;
                NavigationService.Navigate(new CustomizeCombo(combo, isEdit));
            }
            else
            {
                if (DataContext is Order order)
                {
                    order.Add(entree);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
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
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo, isEdit));
            else NavigationService.Navigate(new MenuCategorySelection());
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
            if (entree is SteakosaurusBurger steakosaurus)
            {
                NavigationService.Navigate(new SteakosaurusBurgerSelection(steakosaurus));
            }
            else
            {
                entree = new SteakosaurusBurger();
                SetUpEntreeSelection();
                NavigationService.Navigate(new SteakosaurusBurgerSelection((SteakosaurusBurger)entree));
            }
        }

        /// <summary>
        /// Selects trex kingburger as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingburger(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger kingBurger)
            {
                NavigationService.Navigate(new TRexKingBurgerSelection(kingBurger));
            }
            else
            {
                entree = new TRexKingBurger();
                SetUpEntreeSelection();
                NavigationService.Navigate(new TRexKingBurgerSelection((TRexKingBurger)entree));
            }
        }

        /// <summary>
        /// Selects veloci wrap as the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap velociWrap)
            {
                NavigationService.Navigate(new VelociWrapSelection(velociWrap));
            }
            else
            {
                entree = new VelociWrap();
                SetUpEntreeSelection();
                NavigationService.Navigate(new VelociWrapSelection((VelociWrap)entree));
            }
        }
        /// <summary>
        /// Prepares the EntreeSelection user interface.
        /// </summary>
        private void SetUpEntreeSelection()
        {
            ClearButtonValues();
            if (entree is Brontowurst)
            {
                ConfirmButton.IsEnabled = true;
                BrontowurstButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                BrontowurstButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            else if (entree is DinoNuggets)
            {
                ConfirmButton.IsEnabled = true;
                DinoNuggetsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                DinoNuggetsButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            else if (entree is PrehistoricPBJ)
            {
                ConfirmButton.IsEnabled = true;
                PrehistoricPBJButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                PrehistoricPBJButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            else if (entree is PterodactylWings)
            {
                ConfirmButton.IsEnabled = true;
                PterodactylWingsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                PterodactylWingsButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            else if (entree is SteakosaurusBurger)
            {
                ConfirmButton.IsEnabled = true;
                SteakosaurusBurgerButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                SteakosaurusBurgerButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            else if (entree is TRexKingBurger)
            {
                ConfirmButton.IsEnabled = true;
                TRexKingburgerButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                TRexKingburgerButton.BorderThickness = UserInterfaceOptions.SelectedThickness; ;
            }
            else if (entree is VelociWrap)
            {
                ConfirmButton.IsEnabled = true;
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
