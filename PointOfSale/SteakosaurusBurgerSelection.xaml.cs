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

        private bool isEdit;
        /// <summary>
        /// Initializes the SteakosaurusBurgerSelection page.
        /// </summary>
        /// <param name="steakosaurus"></param>
        public SteakosaurusBurgerSelection(SteakosaurusBurger steakosaurus)
        {
            InitializeComponent();
            this.steakosaurus = steakosaurus;
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Initializes the SteakosaurusBurgerSelection page.
        /// </summary>
        /// <param name="steakosaurus"></param>
        public SteakosaurusBurgerSelection(SteakosaurusBurger steakosaurus, bool isEdit)
        {
            InitializeComponent();
            this.steakosaurus = steakosaurus;
            this.isEdit = isEdit;
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Confirms the properties of the pterodactyl wings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
        {
            if (isEdit)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
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
        }
        /// <summary>
        /// Resets the entree to original values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectReset(object sender, RoutedEventArgs args)
        {
            steakosaurus.AddBun();
            steakosaurus.AddPickle();
            steakosaurus.AddKetchup();
            steakosaurus.AddMustard();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Determines the bun property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBun(object sender, RoutedEventArgs args)
        {
            if (steakosaurus.Bun) steakosaurus.HoldBun();
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
            if (steakosaurus.Pickle) steakosaurus.HoldPickle();
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
            if (steakosaurus.Ketchup) steakosaurus.HoldKetchup();
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
            if (steakosaurus.Mustard) steakosaurus.HoldMustard();
            else steakosaurus.AddMustard();
            SetUpSteakosaurusBurgerSelection();
        }
        /// <summary>
        /// Prepares the SteakosaurusBurgerSelection user interface.
        /// </summary>
        private void SetUpSteakosaurusBurgerSelection()
        {
            ClearButtonValues();
            if (steakosaurus.Bun) BunButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.Pickle) PickleButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.Ketchup) KetchupButton.Background = UserInterfaceOptions.SelectedColor;
            if (steakosaurus.Mustard) MustardButton.Background = UserInterfaceOptions.SelectedColor;
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
