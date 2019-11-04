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

        private bool isEdit;

        private bool isCombo;

        private CretaceousCombo combo;
        /// <summary>
        /// Initialize the SideSelection page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            SetUpSideSelection();
        }
        /// <summary>
        /// Initializes the SideSelection page.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="isEdit"></param>
        public SideSelection(Side side, bool isEdit)
        {
            InitializeComponent();
            this.side = side;
            this.isEdit = isEdit;
            if (isEdit) ConfirmTextBlock.Text = "Confirm";
            SetUpSideSelection();
            CancelButton.IsEnabled = false;
        }
        /// <summary>
        /// Initialize the SideSelection page.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="isEdit"></param>
        public SideSelection(CretaceousCombo combo, bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.combo = combo;
            side = combo.Side;
            isCombo = true;
            ConfirmTextBlock.Text = "Confirm";
            SetUpSideSelection();
        }
        /// <summary>
        /// Confirms the entree selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                combo.Side = side;
                NavigationService.Navigate(new CustomizeCombo(combo, isEdit));
            }
            else
            {
                if (isEdit)
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    if (DataContext is Order order)
                    {
                        order.Add(side);
                        NavigationService.Navigate(new MenuCategorySelection());
                    }
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
        /// Sets the side to fryceritops.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFryceritops(object sender, RoutedEventArgs args)
        {
            side = new Fryceritops();
            SetUpSideSelection();
        }

        /// <summary>
        /// Sets the side to meteor mac and cheese.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            side = new MeteorMacAndCheese();
            SetUpSideSelection();
        }

        /// <summary>
        /// Sets the side to mezzorella sticks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            side = new MezzorellaSticks();
            SetUpSideSelection();
        }

        /// <summary>
        /// Sets the side to triceritots.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
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
            SetSizeButtonValues();
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Medium;
            SetSizeButtonValues();
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Large;
            SetSizeButtonValues();
        }
        /// <summary>
        /// Prepares the SideSelection user interface.
        /// </summary>
        private void SetUpSideSelection()
        {
            DisableButtons();
            ClearButtonValues();
            if (side is Fryceritops fryceritops)
            {
                EnableButtons();
                if (fryceritops.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (fryceritops.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (fryceritops.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                FryceritopsButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                FryceritopsButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is MeteorMacAndCheese mmc)
            {
                EnableButtons();
                if (mmc.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (mmc.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (mmc.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                MeteorMacAndCheeseButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                MeteorMacAndCheeseButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is MezzorellaSticks mezzorella)
            {
                EnableButtons();
                if (mezzorella.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
                if (mezzorella.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
                if (mezzorella.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
                MezzorellaSticksButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                MezzorellaSticksButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (side is Triceritots triceritots)
            {
                EnableButtons();
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
        /// Sets the size button values.
        /// </summary>
        private void SetSizeButtonValues()
        {
            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;
            if (side.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
            if (side.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
            if (side.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Enables all buttons.
        /// </summary>
        private void EnableButtons()
        {
            ConfirmButton.IsEnabled = true;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }
        /// <summary>
        /// Disables necessary buttons.
        /// </summary>
        private void DisableButtons()
        {
            if (isEdit && !isCombo)
            {
                if (!(side is Fryceritops)) FryceritopsButton.IsEnabled = false;
                if (!(side is MeteorMacAndCheese)) MeteorMacAndCheeseButton.IsEnabled = false;
                if (!(side is MezzorellaSticks)) MezzorellaSticksButton.IsEnabled = false;
                if (!(side is Triceritots)) TriceritotsButton.IsEnabled = false;
            }
            ConfirmButton.IsEnabled = false;
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
        }
    }
}
