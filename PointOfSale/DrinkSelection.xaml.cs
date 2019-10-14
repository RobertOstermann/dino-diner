/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; private set; }

        /// <summary>
        /// Initialize the DrinkSelection page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Drink = new Water();
            SmallButton.Background = Brushes.LightGreen;
            SelectSweetButton.IsEnabled = false;
            SelectSweetButton.Visibility = Visibility.Hidden;
            SelectDecafButton.IsEnabled = false;
            SelectDecafButton.Visibility = Visibility.Hidden;
            SelectFlavorButton.IsEnabled = false;
            SelectFlavorButton.Visibility = Visibility.Visible;
            WaterButton.BorderBrush = Brushes.LightGreen;
            WaterButton.BorderThickness = new Thickness(2.5);
        }

        /// <summary>
        /// Sets the drink to sodasaurus.
        /// Enables the flavor button.
        /// Disables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object obj, RoutedEventArgs args)
        {
            Drink = new Sodasaurus();
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
            SelectSweetButton.IsEnabled = false;
            SelectSweetButton.Visibility = Visibility.Hidden;
            SelectDecafButton.IsEnabled = false;
            SelectDecafButton.Visibility = Visibility.Hidden;
            SelectFlavorButton.IsEnabled = true;
            SelectFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.IsEnabled = false;
            SodasaurusButton.BorderBrush = Brushes.LightGreen;
            SodasaurusButton.BorderThickness = new Thickness(2.5);

            TyrannoteaButton.ClearValue(Control.BorderBrushProperty);
            TyrannoteaButton.ClearValue(Control.BorderThicknessProperty);
            JurassicJavaButton.ClearValue(Control.BorderBrushProperty);
            JurassicJavaButton.ClearValue(Control.BorderThicknessProperty);
            WaterButton.ClearValue(Control.BorderBrushProperty);
            WaterButton.ClearValue(Control.BorderThicknessProperty);
        }

        /// <summary>
        /// Sets the drink to tyrannotea.
        /// Enables the sweet button.
        /// Enables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectTyrannotea(object obj, RoutedEventArgs args)
        {
            Drink = new Tyrannotea();
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
            SelectSweetButton.IsEnabled = true;
            SelectSweetButton.Visibility = Visibility.Visible;
            SelectDecafButton.IsEnabled = false;
            SelectDecafButton.Visibility = Visibility.Hidden;
            SelectFlavorButton.IsEnabled = false;
            SelectFlavorButton.Visibility = Visibility.Hidden;
            AddLemonButton.IsEnabled = true;
            TyrannoteaButton.BorderBrush = Brushes.LightGreen;
            TyrannoteaButton.BorderThickness = new Thickness(2.5);

            SodasaurusButton.ClearValue(Control.BorderBrushProperty);
            SodasaurusButton.ClearValue(Control.BorderThicknessProperty);
            JurassicJavaButton.ClearValue(Control.BorderBrushProperty);
            JurassicJavaButton.ClearValue(Control.BorderThicknessProperty);
            WaterButton.ClearValue(Control.BorderBrushProperty);
            WaterButton.ClearValue(Control.BorderThicknessProperty);
        }

        /// <summary>
        /// Sets the drink to Jurrasic Java.
        /// Enables the Decaf button.
        /// Disables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectJurrasicJava(object obj, RoutedEventArgs args)
        {
            Drink = new JurassicJava();
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
            SelectSweetButton.IsEnabled = false;
            SelectSweetButton.Visibility = Visibility.Hidden;
            SelectDecafButton.IsEnabled = true;
            SelectDecafButton.Visibility = Visibility.Visible;
            SelectFlavorButton.IsEnabled = false;
            SelectFlavorButton.Visibility = Visibility.Hidden;
            AddLemonButton.IsEnabled = false;
            JurassicJavaButton.BorderBrush = Brushes.LightGreen;
            JurassicJavaButton.BorderThickness = new Thickness(2.5);

            SodasaurusButton.ClearValue(Control.BorderBrushProperty);
            SodasaurusButton.ClearValue(Control.BorderThicknessProperty);
            TyrannoteaButton.ClearValue(Control.BorderBrushProperty);
            TyrannoteaButton.ClearValue(Control.BorderThicknessProperty);
            WaterButton.ClearValue(Control.BorderBrushProperty);
            WaterButton.ClearValue(Control.BorderThicknessProperty);
        }

        /// <summary>
        /// Sets the drink to Water.
        /// Disables Decaf/Sweet/Flavor buttons.
        /// Enables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectWater(object obj, RoutedEventArgs args)
        {
            Drink = new Water();
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
            SelectSweetButton.IsEnabled = false;
            SelectSweetButton.Visibility = Visibility.Hidden;
            SelectDecafButton.IsEnabled = false;
            SelectDecafButton.Visibility = Visibility.Hidden;
            SelectFlavorButton.IsEnabled = false;
            SelectFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.IsEnabled = true;
            WaterButton.BorderBrush = Brushes.LightGreen;
            WaterButton.BorderThickness = new Thickness(2.5);

            SodasaurusButton.ClearValue(Control.BorderBrushProperty);
            SodasaurusButton.ClearValue(Control.BorderThicknessProperty);
            TyrannoteaButton.ClearValue(Control.BorderBrushProperty);
            TyrannoteaButton.ClearValue(Control.BorderThicknessProperty);
            JurassicJavaButton.ClearValue(Control.BorderBrushProperty);
            JurassicJavaButton.ClearValue(Control.BorderThicknessProperty);
        }

        /// <summary>
        /// Navigate to the FlavorSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        /// <summary>
        /// Adds or removes sweet.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSweet(object obj, RoutedEventArgs args)
        {
            
        }

        /// <summary>
        /// Determines wheter the Tyrannotea is decaf.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectDecaf(object obj, RoutedEventArgs args)
        {

        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(Object obj, RoutedEventArgs args)
        {
            Drink.Size = DinoDiner.Menu.Size.Small;
            SmallButton.Background = Brushes.LightGreen;
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(Object obj, RoutedEventArgs args)
        {
            Drink.Size = DinoDiner.Menu.Size.Medium;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.Background = Brushes.LightGreen;
            LargeButton.ClearValue(Control.BackgroundProperty);
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(Object obj, RoutedEventArgs args)
        {
            Drink.Size = DinoDiner.Menu.Size.Large;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.Background = Brushes.LightGreen;
        }
    }
}
