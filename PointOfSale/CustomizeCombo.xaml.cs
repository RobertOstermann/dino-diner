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
        public CretaceousCombo Combo { get; private set; }

        /// <summary>
        /// Initialize the CustomizeCombo page.
        /// </summary>
        /// <param name="entree"></param>
        public CustomizeCombo(Entree entree)
        {
            InitializeComponent();
            Combo = new CretaceousCombo(entree);
            DrinkChoice.Text = Combo.Drink.ToString();
            SideChoice.Text = Combo.Side.ToString();
        }

        /// <summary>
        /// Navigate to the SideSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSide(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigate to the DrinkSelection page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectDrink(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectSmall(object obj, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectMedium(object obj, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SelectLarge(object obj, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
