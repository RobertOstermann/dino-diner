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
    /// Interaction logic for TRexKingburgerSelection.xaml
    /// </summary>
    public partial class TRexKingBurgerSelection : Page
    {
        private TRexKingBurger kingBurger;

        private bool isEdit;
        /// <summary>
        /// Initializes the TRexKingburgerSelection page.
        /// </summary>
        public TRexKingBurgerSelection(TRexKingBurger kingBurger)
        {
            InitializeComponent();
            this.kingBurger = kingBurger;
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Initializes the TRexKingburgerSelection page.
        /// </summary>
        public TRexKingBurgerSelection(TRexKingBurger kingBurger, bool isEdit)
        {
            InitializeComponent();
            this.kingBurger = kingBurger;
            this.isEdit = isEdit;
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Confirms the properties of the TRexKingburger.
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
            kingBurger.AddBun();
            kingBurger.AddLettuce();
            kingBurger.AddTomato();
            kingBurger.AddOnion();
            kingBurger.AddPickle();
            kingBurger.AddKetchup();
            kingBurger.AddMustard();
            kingBurger.AddMayo();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the bun property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBun(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Bun) kingBurger.HoldBun();
            else kingBurger.AddBun();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the lettuce property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLettuce(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Lettuce) kingBurger.HoldLettuce();
            else kingBurger.AddLettuce();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the tomato property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTomato(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Tomato) kingBurger.HoldTomato();
            else kingBurger.AddTomato();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the onion property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectOnion(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Onion) kingBurger.HoldOnion();
            else kingBurger.AddOnion();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the pickle property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPickle(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Pickle) kingBurger.HoldPickle();
            else kingBurger.AddPickle();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the ketchup property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectKetchup(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Ketchup) kingBurger.HoldKetchup();
            else kingBurger.AddKetchup();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the mustard property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMustard(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Mustard) kingBurger.HoldMustard();
            else kingBurger.AddMustard();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Determines the mayo property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMayo(object sender, RoutedEventArgs args)
        {
            if (kingBurger.Mayo) kingBurger.HoldMayo();
            else kingBurger.AddMayo();
            SetUpTRexKingburgerSelection();
        }
        /// <summary>
        /// Prepares the TRexKingburgerSelection user interface.
        /// </summary>
        private void SetUpTRexKingburgerSelection()
        {
            ClearButtonValues();
            if (kingBurger.Bun) BunButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Lettuce) LettuceButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Tomato) TomatoButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Onion) OnionButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Pickle) PickleButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Ketchup) KetchupButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Mustard) MustardButton.Background = UserInterfaceOptions.SelectedColor;
            if (kingBurger.Mayo) MayoButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            BunButton.Background = UserInterfaceOptions.BaseColor;
            LettuceButton.Background = UserInterfaceOptions.BaseColor;
            TomatoButton.Background = UserInterfaceOptions.BaseColor;
            OnionButton.Background = UserInterfaceOptions.BaseColor;
            PickleButton.Background = UserInterfaceOptions.BaseColor;
            KetchupButton.Background = UserInterfaceOptions.BaseColor;
            MustardButton.Background = UserInterfaceOptions.BaseColor;
            MayoButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
