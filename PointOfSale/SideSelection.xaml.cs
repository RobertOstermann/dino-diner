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

        private Brush buttonColor = Brushes.LightGreen;

        private Thickness buttonBorderThickness = new Thickness(2.5);

        /// <summary>
        /// Initialize the SideSelection page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            DisableButtons();
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
            ClearButtonValues();
            side = new Fryceritops();
            FryceritopsButton.BorderBrush = buttonColor;
            FryceritopsButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            ClearButtonValues();
            side = new MeteorMacAndCheese();
            MeteorMacAndCheeseButton.BorderBrush = buttonColor;
            MeteorMacAndCheeseButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            ClearButtonValues();
            side = new Fryceritops();
            MezzorellaSticksButton.BorderBrush = buttonColor;
            MezzorellaSticksButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Selects the specified side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
            EnableButtons();
            ClearButtonValues();
            side = new Fryceritops();
            TriceritotsButton.BorderBrush = buttonColor;
            TriceritotsButton.BorderThickness = buttonBorderThickness;
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Small;
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Medium;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.Background = Brushes.LightGreen;
            LargeButton.ClearValue(Control.BackgroundProperty);
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            side.Size = DinoDiner.Menu.Size.Large;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.Background = Brushes.LightGreen;
        }

        private void ClearButtonValues()
        {
            FryceritopsButton.ClearValue(Control.BorderBrushProperty);
            FryceritopsButton.ClearValue(Control.BorderThicknessProperty);
            MeteorMacAndCheeseButton.ClearValue(Control.BorderBrushProperty);
            MeteorMacAndCheeseButton.ClearValue(Control.BorderThicknessProperty);
            MezzorellaSticksButton.ClearValue(Control.BorderBrushProperty);
            MezzorellaSticksButton.ClearValue(Control.BorderThicknessProperty);
            TriceritotsButton.ClearValue(Control.BorderBrushProperty);
            TriceritotsButton.ClearValue(Control.BorderThicknessProperty);
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
