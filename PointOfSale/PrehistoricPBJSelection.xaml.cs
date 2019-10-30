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
    /// Interaction logic for PrehistoricPBJSelection.xaml
    /// </summary>
    public partial class PrehistoricPBJSelection : Page
    {
        private PrehistoricPBJ pbj;

        private bool isEdit;
        /// <summary>
        /// Initialize the PrehistoricPBJSelection page.
        /// </summary>
        /// <param name="pbj"></param>
        public PrehistoricPBJSelection(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
            SetUpPrehistoricPBJSelection();
        }
        /// <summary>
        /// Initialize the PrehistoricPBJSelection page.
        /// </summary>
        /// <param name="pbj"></param>
        public PrehistoricPBJSelection(PrehistoricPBJ pbj, bool isEdit)
        {
            InitializeComponent();
            this.pbj = pbj;
            this.isEdit = isEdit;
            SetUpPrehistoricPBJSelection();
        }
        /// <summary>
        /// Confirms the properties of the pbj.
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
        /// Resets the entree to the original values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectReset(object sender, RoutedEventArgs args)
        {
            pbj.AddPeanutButter();
            pbj.AddJelly();
            SetUpPrehistoricPBJSelection();
        }
        /// <summary>
        /// Determines the peanut butter property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPeanutButter(object sender, RoutedEventArgs args)
        {
            if (pbj.PeanutButter) pbj.HoldPeanutButter();
            else pbj.AddPeanutButter();
            SetUpPrehistoricPBJSelection();
        }
        /// <summary>
        /// Determines the jelly property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectJelly(object sender, RoutedEventArgs args)
        {
            if (pbj.Jelly) pbj.HoldJelly();
            else pbj.AddJelly();
            SetUpPrehistoricPBJSelection();
        }

        /// <summary>
        /// Prepares the PrehistoricPBJSelection user interface.
        /// </summary>
        private void SetUpPrehistoricPBJSelection()
        {
            ClearButtonValues();
            if (pbj.PeanutButter) PeanutButterButton.Background = UserInterfaceOptions.SelectedColor;
            if (pbj.Jelly) JellyButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            PeanutButterButton.Background = UserInterfaceOptions.BaseColor;
            JellyButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
