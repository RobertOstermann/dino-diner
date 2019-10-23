﻿/* DrinkSelection.xaml.cs
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

        private Brush buttonColor = Brushes.LightGreen;

        private Thickness buttonBorderThickness = new Thickness(2.5);

        /// <summary>
        /// Initialize the DrinkSelection page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Drink = new Water();
            SmallButton.Background = buttonColor;
            SweetButton.IsEnabled = false;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.IsEnabled = false;
            DecafButton.Visibility = Visibility.Hidden;
            FlavorButton.IsEnabled = false;
            FlavorButton.Visibility = Visibility.Visible;
            WaterButton.BorderBrush = buttonColor;
            WaterButton.BorderThickness = buttonBorderThickness;
            IceButton.Background = buttonColor;
            //CHANGE
            if (DataContext is Order order)
            {
                order.Items.Add(Drink);
            }
        }

        /// <summary>
        /// Sets the drink to sodasaurus.
        /// Enables the flavor button.
        /// Disables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (Drink.GetType() != typeof(Sodasaurus))
            {
                Drink = new Sodasaurus();
                ClearButtonValues();
                //Set the size buttons to represent small as selected.
                SmallButton.Background = buttonColor;

                //Show or hide correct property buttons for the drink.
                SweetButton.IsEnabled = false;
                SweetButton.Visibility = Visibility.Hidden;
                DecafButton.IsEnabled = false;
                DecafButton.Visibility = Visibility.Hidden;
                FlavorButton.IsEnabled = true;
                FlavorButton.Visibility = Visibility.Visible;
                LemonButton.IsEnabled = false;

                SodasaurusButton.BorderBrush = buttonColor;
                SodasaurusButton.BorderThickness = buttonBorderThickness;
                IceButton.Background = buttonColor;
            }
        }

        /// <summary>
        /// Sets the drink to tyrannotea.
        /// Enables the sweet button.
        /// Enables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (Drink.GetType() != typeof(Tyrannotea))
            {
                Drink = new Tyrannotea();
                ClearButtonValues();
                //Set the size buttons to represent small as selected.
                SmallButton.Background = buttonColor;

                //Show or hide correct property buttons for the drink.
                SweetButton.IsEnabled = true;
                SweetButton.Visibility = Visibility.Visible;
                DecafButton.IsEnabled = false;
                DecafButton.Visibility = Visibility.Hidden;
                FlavorButton.IsEnabled = false;
                FlavorButton.Visibility = Visibility.Hidden;
                LemonButton.IsEnabled = true;

                TyrannoteaButton.BorderBrush = buttonColor;
                TyrannoteaButton.BorderThickness = buttonBorderThickness;
                IceButton.Background = buttonColor;
            }
        }

        /// <summary>
        /// Sets the drink to Jurrasic Java.
        /// Enables the Decaf button.
        /// Disables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectJurrasicJava(object sender, RoutedEventArgs args)
        {
            if (Drink.GetType() != typeof(JurassicJava))
            {
                Drink = new JurassicJava();
                ClearButtonValues();
                //Set the size buttons to represent small as selected.
                SmallButton.Background = buttonColor;
                
                //Show or hide correct property buttons for the drink.
                SweetButton.IsEnabled = false;
                SweetButton.Visibility = Visibility.Hidden;
                DecafButton.IsEnabled = true;
                DecafButton.Visibility = Visibility.Visible;
                FlavorButton.IsEnabled = false;
                FlavorButton.Visibility = Visibility.Hidden;
                LemonButton.IsEnabled = false;

                JurassicJavaButton.BorderBrush = buttonColor;
                JurassicJavaButton.BorderThickness = buttonBorderThickness;

            }
        }

        /// <summary>
        /// Sets the drink to Water.
        /// Disables Decaf/Sweet/Flavor buttons.
        /// Enables the lemon button.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            if (Drink.GetType() != typeof(Water))
            {
                Drink = new Water();
                ClearButtonValues();
                //Set the size buttons to represent small as selected.
                SmallButton.Background = buttonColor;

                //Show or hide correct property buttons for the drink.
                SweetButton.IsEnabled = false;
                SweetButton.Visibility = Visibility.Hidden;
                DecafButton.IsEnabled = false;
                DecafButton.Visibility = Visibility.Hidden;
                FlavorButton.IsEnabled = false;
                FlavorButton.Visibility = Visibility.Visible;
                LemonButton.IsEnabled = true;

                WaterButton.BorderBrush = buttonColor;
                WaterButton.BorderThickness = buttonBorderThickness;
                IceButton.Background = buttonColor;
            }
        }

        /// <summary>
        /// Navigate to the FlavorSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        /// <summary>
        /// Adds or removes sweet.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSweet(object sender, RoutedEventArgs args)
        {
            Tyrannotea tea = Drink as Tyrannotea;
            if (tea != null)
            {
                if (tea.Sweet)
                {
                    tea.Sweet = false;
                    SweetButton.ClearValue(Control.BackgroundProperty);
                }
                else
                {
                    tea.Sweet = true;
                    SweetButton.Background = buttonColor;
                }
            }
        }

        /// <summary>
        /// Determines whether the Jurassic Java is decaf.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                if (java.Decaf)
                {
                    java.Decaf = false;
                    DecafButton.ClearValue(Control.BackgroundProperty);
                }
                else
                {
                    java.Decaf = true;
                    DecafButton.Background = buttonColor;
                }
            }
        }
        /// <summary>
        /// Determines whether the drink has a lemon.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Water water)
            {
                if (water.Lemon)
                {
                    water.RemoveLemon();
                    LemonButton.ClearValue(BackgroundProperty);
                }
                else
                {
                    water.AddLemon();
                    LemonButton.Background = buttonColor;
                }
            }
            if (Drink is Tyrannotea tea)
            {
                if (tea.Lemon)
                {
                    tea.RemoveLemon();
                    LemonButton.ClearValue(BackgroundProperty);
                }
                else
                { 
                    tea.AddLemon();
                    LemonButton.Background = buttonColor;
                }
            }
        }
        /// <summary>
        /// Determines whether the drink has ice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectIce(object sender, RoutedEventArgs args)
        {
            if (Drink.Ice)
            {
                Drink.HoldIce();
                IceButton.ClearValue(BackgroundProperty);
            }
            else
            {
                Drink.Ice = true;
                IceButton.Background = buttonColor;
            }
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            Drink.Size = DinoDiner.Menu.Size.Small;
            SmallButton.Background = buttonColor;
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
            Drink.Size = DinoDiner.Menu.Size.Medium;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.Background = buttonColor;
            LargeButton.ClearValue(Control.BackgroundProperty);
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            Drink.Size = DinoDiner.Menu.Size.Large;
            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.Background = buttonColor;
        }

        private void ClearButtonValues()
        {
            WaterButton.ClearValue(Control.BorderBrushProperty);
            WaterButton.ClearValue(Control.BorderThicknessProperty);
            SodasaurusButton.ClearValue(Control.BorderBrushProperty);
            SodasaurusButton.ClearValue(Control.BorderThicknessProperty);
            TyrannoteaButton.ClearValue(Control.BorderBrushProperty);
            TyrannoteaButton.ClearValue(Control.BorderThicknessProperty);
            JurassicJavaButton.ClearValue(Control.BorderBrushProperty);
            JurassicJavaButton.ClearValue(Control.BorderThicknessProperty);

            SmallButton.ClearValue(Control.BackgroundProperty);
            MediumButton.ClearValue(Control.BackgroundProperty);
            LargeButton.ClearValue(Control.BackgroundProperty);

            FlavorButton.ClearValue(Control.BackgroundProperty);
            DecafButton.ClearValue(Control.BackgroundProperty);
            SweetButton.ClearValue(Control.BackgroundProperty);
            LemonButton.ClearValue(Control.BackgroundProperty);
            IceButton.ClearValue(Control.BackgroundProperty);
        }
    }
}
