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
        private Drink drink;

        private bool isEdit;

        private bool isCombo;

        private CretaceousCombo combo;
        /// <summary>
        /// Initialize the DrinkSelection page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            SetUpDrinkSelection();
            FlavorButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Initializes the DrinkSelection page.
        /// </summary>
        /// <param name="currentDrink"></param>
        public DrinkSelection(CretaceousCombo combo, bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.combo = combo;
            drink = combo.Drink;
            isCombo = true;
            ConfirmTextBlock.Text = "Confirm";
            SetUpDrinkSelection();
        }
        /// <summary>
        /// Initialize the DrinkSelection page.
        /// </summary>
        public DrinkSelection(Drink drink, bool isEdit)
        {
            InitializeComponent();
            this.drink = drink;
            this.isEdit = isEdit;
            if (isEdit)
            {
                ConfirmTextBlock.Text = "Confirm";
                CancelButton.IsEnabled = false;
            }
            SetUpDrinkSelection();
            FlavorButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Adds the drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                combo.Drink = drink;
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
                        order.Add(drink);
                        NavigationService.Navigate(new MenuCategorySelection());
                    }
                }
            }
        }

        /// <summary>
        /// Returns to the category selection page.
        /// Does not add the drink to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo, isEdit));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Sets the drink to Water.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            if (!(drink is Water))
            {
                drink = new Water();
                SetUpDrinkSelection();
            }
        }
        /// <summary>
        /// Sets the drink to sodasaurus.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (!(drink is Sodasaurus))
            {
                drink = new Sodasaurus();
                SetUpDrinkSelection();
            }
        }

        /// <summary>
        /// Sets the drink to tyrannotea.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (!(drink is Tyrannotea))
            {
                drink = new Tyrannotea();
                SetUpDrinkSelection();
            }
        }

        /// <summary>
        /// Sets the drink to Jurrasic Java.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectJurrasicJava(object sender, RoutedEventArgs args)
        {
            if (!(drink is JurassicJava))
            {
                drink = new JurassicJava();
                SetUpDrinkSelection();
            }
        }
        /// <summary>
        /// Navigate to the FlavorSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }
        /// <summary>
        /// Determines whether the tea is sweet.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSweet(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                if (tea.Sweet)
                {
                    tea.Sweet = false;
                    SweetButton.Background = UserInterfaceOptions.BaseColor;
                }
                else
                {
                    tea.Sweet = true;
                    SweetButton.Background = UserInterfaceOptions.SelectedColor;
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
            if (drink is JurassicJava java)
            {
                if (java.Decaf)
                {
                    java.Decaf = false;
                    DecafButton.Background = UserInterfaceOptions.BaseColor;
                }
                else
                {
                    java.Decaf = true;
                    DecafButton.Background = UserInterfaceOptions.SelectedColor;
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
            if (drink is Water water)
            {
                if (water.Lemon)
                {
                    water.RemoveLemon();
                    LemonButton.Background = UserInterfaceOptions.BaseColor;
                }
                else
                {
                    water.AddLemon();
                    LemonButton.Background = UserInterfaceOptions.SelectedColor;
                }
            }
            if (drink is Tyrannotea tea)
            {
                if (tea.Lemon)
                {
                    tea.RemoveLemon();
                    LemonButton.Background = UserInterfaceOptions.BaseColor;
                }
                else
                { 
                    tea.AddLemon();
                    LemonButton.Background = UserInterfaceOptions.SelectedColor;
                }
            }
        }
        /// <summary>
        /// Determines whether the drink has room for cream.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCream(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava java)
            {
                if (java.RoomForCream)
                {
                    java.RemoveRoomForCream();
                    CreamButton.Background = UserInterfaceOptions.BaseColor;
                }
                else
                {
                    java.LeaveRoomForCream();
                    CreamButton.Background = UserInterfaceOptions.SelectedColor;
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
            if (drink.Ice)
            {
                drink.HoldIce();
                IceButton.Background = UserInterfaceOptions.BaseColor;
            }
            else
            {
                drink.AddIce();
                IceButton.Background = UserInterfaceOptions.SelectedColor;
            }
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            drink.Size = DinoDiner.Menu.Size.Small;
            SetSizeButtonValues();
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            drink.Size = DinoDiner.Menu.Size.Medium;
            SetSizeButtonValues();
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            drink.Size = DinoDiner.Menu.Size.Large;
            SetSizeButtonValues();
        }
        /// <summary>
        /// Prepares the DrinkSelection user interface.
        /// </summary>
        private void SetUpDrinkSelection()
        {
            DisableButtons();
            ClearButtonValues();
            if (drink is Water water)
            {
                HideAndDisableAndEnableButtons();
                //Set the correct button backgrounds.
                SetSizeButtonValues();
                if (water.Ice) IceButton.Background = UserInterfaceOptions.SelectedColor;
                if (water.Lemon) LemonButton.Background = UserInterfaceOptions.SelectedColor;
                //Show or hide the correct property buttons for the drink.
                FlavorButton.Visibility = Visibility.Visible;
                LemonButton.IsEnabled = true;
                LemonButton.Visibility = Visibility.Visible;

                WaterButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                WaterButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (drink is Sodasaurus soda)
            {
                HideAndDisableAndEnableButtons();
                //Set the correct button backgrounds.
                SetSizeButtonValues();
                if (soda.Ice) IceButton.Background = UserInterfaceOptions.SelectedColor;
                //Show or hide the correct property buttons for the drink.
                FlavorButton.IsEnabled = true;
                FlavorButton.Visibility = Visibility.Visible;
                LemonButton.Visibility = Visibility.Visible;

                SodasaurusButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                SodasaurusButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (drink is Tyrannotea tea)
            {
                HideAndDisableAndEnableButtons();
                //Set the correct button backgrounds.
                SetSizeButtonValues();
                if (tea.Ice) IceButton.Background = UserInterfaceOptions.SelectedColor;
                if (tea.Sweet) SweetButton.Background = UserInterfaceOptions.SelectedColor;
                if (tea.Lemon) LemonButton.Background = UserInterfaceOptions.SelectedColor;
                //Show or hide the correct property buttons for the drink.
                SweetButton.IsEnabled = true;
                SweetButton.Visibility = Visibility.Visible;
                LemonButton.IsEnabled = true;
                LemonButton.Visibility = Visibility.Visible;

                TyrannoteaButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                TyrannoteaButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
            if (drink is JurassicJava java)
            {
                HideAndDisableAndEnableButtons();
                //Set the correct button backgrounds.
                SetSizeButtonValues();
                if (java.Ice) IceButton.Background = UserInterfaceOptions.SelectedColor;
                if (java.Decaf) DecafButton.Background = UserInterfaceOptions.SelectedColor;
                if (java.RoomForCream) CreamButton.Background = UserInterfaceOptions.SelectedColor;
                //Show or hide the correct property buttons for the drink.
                DecafButton.IsEnabled = true;
                DecafButton.Visibility = Visibility.Visible;
                CreamButton.IsEnabled = true;
                CreamButton.Visibility = Visibility.Visible;

                JurassicJavaButton.BorderBrush = UserInterfaceOptions.SelectedColor;
                JurassicJavaButton.BorderThickness = UserInterfaceOptions.SelectedThickness;
            }
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            WaterButton.BorderBrush = UserInterfaceOptions.BaseColor;
            WaterButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            SodasaurusButton.BorderBrush = UserInterfaceOptions.BaseColor;
            SodasaurusButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            TyrannoteaButton.BorderBrush = UserInterfaceOptions.BaseColor;
            TyrannoteaButton.BorderThickness = UserInterfaceOptions.BaseThickness;
            JurassicJavaButton.BorderBrush = UserInterfaceOptions.BaseColor;
            JurassicJavaButton.BorderThickness = UserInterfaceOptions.BaseThickness;

            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;

            FlavorButton.Background = UserInterfaceOptions.BaseColor;
            DecafButton.Background = UserInterfaceOptions.BaseColor;
            SweetButton.Background = UserInterfaceOptions.BaseColor;
            LemonButton.Background = UserInterfaceOptions.BaseColor;
            CreamButton.Background = UserInterfaceOptions.BaseColor;
            IceButton.Background = UserInterfaceOptions.BaseColor;
        }

        /// <summary>
        /// Sets the size button values.
        /// </summary>
        private void SetSizeButtonValues()
        {
            SmallButton.Background = UserInterfaceOptions.BaseColor;
            MediumButton.Background = UserInterfaceOptions.BaseColor;
            LargeButton.Background = UserInterfaceOptions.BaseColor;
            if (drink.Size == DinoDiner.Menu.Size.Small) SmallButton.Background = UserInterfaceOptions.SelectedColor;
            if (drink.Size == DinoDiner.Menu.Size.Medium) MediumButton.Background = UserInterfaceOptions.SelectedColor;
            if (drink.Size == DinoDiner.Menu.Size.Large) LargeButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Hides and disables property buttons.
        /// Enables size buttons.
        /// </summary>
        private void HideAndDisableAndEnableButtons()
        {
            if (isEdit && !isCombo)
            {
                if (!(drink is Water)) WaterButton.IsEnabled = false;
                if (!(drink is Sodasaurus)) SodasaurusButton.IsEnabled = false;
                if (!(drink is Tyrannotea)) TyrannoteaButton.IsEnabled = false;
                if (!(drink is JurassicJava)) JurassicJavaButton.IsEnabled = false;
            }
            FlavorButton.IsEnabled = false;
            FlavorButton.Visibility = Visibility.Hidden;
            DecafButton.IsEnabled = false;
            DecafButton.Visibility = Visibility.Hidden;
            SweetButton.IsEnabled = false;
            SweetButton.Visibility = Visibility.Hidden;
            LemonButton.IsEnabled = false;
            LemonButton.Visibility = Visibility.Hidden;
            CreamButton.IsEnabled = false;
            CreamButton.Visibility = Visibility.Hidden;
            IceButton.IsEnabled = true;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
            ConfirmButton.IsEnabled = true;
        }
        /// <summary>
        /// Disables all the non-drink buttons.
        /// </summary>
        private void DisableButtons()
        {
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = false;
            FlavorButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
            CreamButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            ConfirmButton.IsEnabled = false;
        }
    }
}
