/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;

        /// <summary>
        /// Initialize the SideSelection page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            DisableButtons();
        }
        /// <summary>
        /// Initialize the SideSelection page.
        /// </summary>
        /// <param name="currentSide"></param>
        public SideSelection(Side currentSide)
        {
            InitializeComponent();
            DisableButtons();
            side = currentSide;
            SetUpSideSelection();
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
                order.Add(side);
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
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFryceritops(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            side = new Fryceritops();
            SetUpSideSelection();
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            side = new MeteorMacAndCheese();
            SetUpSideSelection();
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            side = new MezzorellaSticks();
            SetUpSideSelection();
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            side = new Triceritots();
            SetUpSideSelection();
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Small;
            ClearSizeButtonValues();
            SmallButton.Background = UserInterfaceOptions.SelectedColor;
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Medium;
            ClearSizeButtonValues();
            MediumButton.Background = UserInterfaceOptions.SelectedColor;
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Large;
            ClearSizeButtonValues();
            LargeButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Prepares the SideSelection user interface.
        /// </summary>
        private void SetUpSideSelection()
        {
            ClearButtonValues();
            if (side is Fryceritops fryceritops)
            {
                if (fryceritops.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (fryceritops.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (fryceritops.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                FryceritopsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                FryceritopsButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is MeteorMacAndCheese mmc)
            {
                if (mmc.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (mmc.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (mmc.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                MeteorMacAndCheeseButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                MeteorMacAndCheeseButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is MezzorellaSticks mezzorella)
            {
                if (mezzorella.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (mezzorella.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (mezzorella.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                MezzorellaSticksButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                MezzorellaSticksButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is Triceritots triceritots)
            {
                if (triceritots.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (triceritots.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (triceritots.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                TriceritotsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                TriceritotsButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            FryceritopsButton.BorderBrush = UserInterfaceOptions.BaseColor;
            FryceritopsButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            MeteorMacAndCheeseButton.BorderBrush = UserInterfaceOptions.BaseColor;
            MeteorMacAndCheeseButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            MezzorellaSticksButton.BorderBrush = UserInterfaceOptions.BaseColor;
            MezzorellaSticksButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            TriceritotsButton.BorderBrush = UserInterfaceOptions.BaseColor;
            TriceritotsButton.BorderThickness = UserInterfaceOptions.BaseThickness;

            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;
        }
        /// <summary>
        /// Resets the size button values.
        /// </summary>
        private void ClearSizeButtonValues()
        {
            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;
        }
        /// <summary>
        /// Enables all buttons.
        /// </summary>
        private void EnableButtons()
        {
            AddToOrderButton.IsEnabled = true;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }
        /// <summary>
        /// Disables necessary buttons.
        /// </summary>
        private void DisableButtons()
        {
            AddToOrderButton.IsEnabled = false;
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
        }
    }
}
