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
        private void BrontowurstCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void DinoNuggetsCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void PrehistoricPBJCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void PterodactylWingsCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void SteakosaurusBurgerCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void TRexKingburgerCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// Navigate to the CustomizeCombo page.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void VelociWrapCombo(Object obj, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

    }
}
