/* BrontowurstSelection.xaml.cs
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
    /// Interaction logic for BrontowurstSelection.xaml
    /// </summary>
    public partial class BrontowurstSelection : Page
    {
        private Brontowurst brontowurst;

        private bool isEdit;
        /// <summary>
        /// Initializes the BrontowurstSelection page.
        /// </summary>
        /// <param name="brontowurst"></param>
        public BrontowurstSelection(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
            SetUpBrontowurstSelection();
        }
        /// <summary>
        /// Initializes the BrontowurstSelection page.
        /// </summary>
        /// <param name="brontowurst"></param>
        /// <param name="isEdit"></param>
        public BrontowurstSelection(Brontowurst brontowurst, bool isEdit)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
            this.isEdit = isEdit;
            SetUpBrontowurstSelection();
        }

        /// <summary>
        /// Confirms the properties of the brontowurst.
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
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
        /// <summary>
        /// Resets the entree to original values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectReset(object sender, RoutedEventArgs args)
        {
            brontowurst.AddBun();
            brontowurst.AddPeppers();
            brontowurst.AddOnion();
            SetUpBrontowurstSelection();
        }
        /// <summary>
        /// Determines the bun property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBun(object sender, RoutedEventArgs args)
        {
            if (brontowurst.Bun) brontowurst.HoldBun();
            else brontowurst.AddBun();
            SetUpBrontowurstSelection();
        }
        /// <summary>
        /// Determines the peppers property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPeppers(object sender, RoutedEventArgs args)
        {
            if (brontowurst.Peppers) brontowurst.HoldPeppers();
            else brontowurst.AddPeppers();
            SetUpBrontowurstSelection();
        }
        /// <summary>
        /// Determines the onion property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectOnion(object sender, RoutedEventArgs args)
        {
            if (brontowurst.Onions) brontowurst.HoldOnion();
            else brontowurst.AddOnion();
            SetUpBrontowurstSelection();
        }
        /// <summary>
        /// Prepares the BrontowurstSelection user interface.
        /// </summary>
        private void SetUpBrontowurstSelection()
        {
            ClearButtonValues();
            if (brontowurst.Bun) BunButton.Background = UserInterfaceOptions.SelectedColor;
            if (brontowurst.Peppers) PeppersButton.Background = UserInterfaceOptions.SelectedColor;
            if (brontowurst.Onions) OnionButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            BunButton.Background = UserInterfaceOptions.BaseColor;
            PeppersButton.Background = UserInterfaceOptions.BaseColor;
            OnionButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
