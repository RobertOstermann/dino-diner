/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void BrontowurstCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new Brontowurst()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void DinoNuggetsCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new DinoNuggets()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void PrehistoricPBJCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new PrehistoricPBJ()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void PterodactylWingsCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new PterodactylWings()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SteakosaurusBurgerCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new SteakosaurusBurger()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void TRexKingburgerCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new TRexKingBurger()));
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void VelociWrapCombo(object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new VelociWrap()));
        }

    }
}
