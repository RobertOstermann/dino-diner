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

        /// <summary>
        /// Initialize the CustomizeCombo page.
        /// </summary>
        /// <param name="entree"></param>
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            SetUpCustomizeComboSelection();
            combo = new CretaceousCombo(entree);
            DrinkChoice.Text = combo.Drink.ToString();
            SideChoice.Text = combo.Side.ToString();
        }

        /// <summary>
        /// Navigate to the SideSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo.Side));
        }

        /// <summary>
        /// Navigate to the DrinkSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo.Drink));
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            combo.Size = DinoDiner.Menu.Size.Small;
            SmallButton.Background = Brushes.LightGreen;
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            combo.Size = DinoDiner.Menu.Size.Medium;
            MediumButton.Background = Brushes.LightGreen;
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            ClearButtonValues();
            combo.Size = DinoDiner.Menu.Size.Large;
            LargeButton.Background = Brushes.LightGreen;
        }
        /// <summary>
        /// Prepares the EntreeSelection user interface.
        /// </summary>
        private void SetUpCustomizeComboSelection()
        {
            ClearButtonValues();
            SideButton.Background = UserInterfaceOptions.BaseColor;
            DrinkButton.Background = UserInterfaceOptions.BaseColor;
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
