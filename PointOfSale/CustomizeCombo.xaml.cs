/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;

        private bool isEdit;
        /// <summary>
        /// Initialize the CustomizeCombo page.
        /// </summary>
        /// <param name="entree"></param>
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            combo = new CretaceousCombo(entree);
            SetUpCustomizeComboSelection();
        }
        /// <summary>
        /// Initialize the CustomizeCombo page.
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo, bool isEdit)
        {
            InitializeComponent();
            this.combo = combo;
            this.isEdit = isEdit;
            SetUpCustomizeComboSelection();
            if (combo.Size != combo.Drink.Size || combo.Size != combo.Side.Size) ClearButtonValues();
            ComboTextBlock.Text = combo.ToString();
            DrinkChoice.Text = combo.Drink.ToString();
            SideChoice.Text = combo.Side.ToString();
            if (isEdit)
            {
                CancelButton.IsEnabled = false;
                ConfirmTextBlock.Text = "Confirm";
            }
        }
        /// <summary>
        /// Adds the combo to the order.
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
                if (DataContext is Order order)
                {
                    order.Add(combo);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        /// <summary>
        /// Returns to the category selection page.
        /// Does not add the combo to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Navigate to the SideSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection(combo, isEdit));
        }
        /// <summary>
        /// Navigate to the SideSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo, isEdit));
        }
        /// <summary>
        /// Navigate to the DrinkSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo, isEdit));
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
            SetUpCustomizeComboSelection();
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
            SetUpCustomizeComboSelection();
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
            SetUpCustomizeComboSelection();
        }
        /// <summary>
        /// Prepares the EntreeSelection user interface.
        /// </summary>
        private void SetUpCustomizeComboSelection()
        {
            ClearButtonValues();
            if (combo.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
            if (combo.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
            if (combo.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
            EntreeButton.Background = UserInterfaceOptions.BaseColor;
            SideButton.Background = UserInterfaceOptions.BaseColor;
            DrinkButton.Background = UserInterfaceOptions.BaseColor;
            ComboTextBlock.Text = combo.ToString();
            EntreeChoice.Text = combo.Entree.ToString();
            DrinkChoice.Text = combo.Drink.ToString();
            SideChoice.Text = combo.Side.ToString();
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
