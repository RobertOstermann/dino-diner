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
    /// Interaction logic for VelociWrapSelection.xaml
    /// </summary>
    public partial class VelociWrapSelection : Page
    {
        private VelociWrap velociWrap;
        public VelociWrapSelection(VelociWrap velociWrap)
        {
            InitializeComponent();
            this.velociWrap = velociWrap;
            SetUpVelociWrapSelection();
        }

        /// <summary>
        /// Confirms the properties of the veloci wrap.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectConfirm(object sender, RoutedEventArgs args)
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
        /// <summary>
        /// Returns to the entree selection page.
        /// Does not add the veloci wrap to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Determines the dressing property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDressing(object sender, RoutedEventArgs args)
        {
            if (velociWrap.Dressing) velociWrap.HoldDressing();
            else velociWrap.AddDressing();
            SetUpVelociWrapSelection();
        }
        /// <summary>
        /// Determines the lettuce property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLettuce(object sender, RoutedEventArgs args)
        {
            if (velociWrap.Lettuce) velociWrap.HoldLettuce();
            else velociWrap.AddLettuce();
            SetUpVelociWrapSelection();
        }
        /// <summary>
        /// Determines the cheese property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCheese(object sender, RoutedEventArgs args)
        {
            if (velociWrap.Cheese) velociWrap.HoldCheese();
            else velociWrap.AddCheese();
            SetUpVelociWrapSelection();
        }
        /// <summary>
        /// Prepares the VelociWrapSelection user interface.
        /// </summary>
        private void SetUpVelociWrapSelection()
        {
            ClearButtonValues();
            if (velociWrap.Dressing) DressingButton.Background = UserInterfaceOptions.SelectedColor;
            if (velociWrap.Lettuce) LettuceButton.Background = UserInterfaceOptions.SelectedColor;
            if (velociWrap.Cheese) CheeseButton.Background = UserInterfaceOptions.SelectedColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            DressingButton.Background = UserInterfaceOptions.BaseColor;
            LettuceButton.Background = UserInterfaceOptions.BaseColor;
            CheeseButton.Background = UserInterfaceOptions.BaseColor;
        }
    }
}
