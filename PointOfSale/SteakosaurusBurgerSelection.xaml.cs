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
    /// Interaction logic for PterodactylWingsSelection.xaml
    /// </summary>
    public partial class SteakosaurusBurgerSelection : Page
    {
        private SteakosaurusBurger steakosaurus;
        public SteakosaurusBurgerSelection(SteakosaurusBurger steakosaurus)
        {
            InitializeComponent();
            this.steakosaurus = steakosaurus;
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Confirms the properties of the pterodactyl wings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
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
        /// Returns to the entree selection page.
        /// Does not add the pterodactyl wings to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Determines the bun property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBun(object sender, RoutedEventArgs args)
        {
            if (steakosaurus.bun) steakosaurus.HoldBun();
            else steakosaurus.AddBun();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Determines the pickle property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPickle(object sender, RoutedEventArgs args)
        {
            if (steakosaurus.pickle) steakosaurus.HoldPickle();
            else steakosaurus.AddPickle();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Determines the ketchup property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectKetchup(object sender, RoutedEventArgs args)
        {
            if (steakosaurus.ketchup) steakosaurus.HoldKetchup();
            else steakosaurus.AddKetchup();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Determines the mustard property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMustard(object sender, RoutedEventArgs args)
        {
            if (steakosaurus.mustard) steakosaurus.HoldMustard();
            else steakosaurus.AddMustard();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Prepares the SteakosaurusBurgerSelection user interface.
        /// </summary>
        private void SetUpSteakosaurusBurgerSelection()
        {
            ClearButtonValues();
            if (steakosaurus.bun) BunButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.pickle) PickleButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.ketchup) KetchupButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.mustard) MustardButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            BunButton.Background = UserInterfaceOptions.BaseColor;
            PickleButton.Background = UserInterfaceOptions.BaseColor;
            KetchupButton.Background = UserInterfaceOptions.BaseColor;
            MustardButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
