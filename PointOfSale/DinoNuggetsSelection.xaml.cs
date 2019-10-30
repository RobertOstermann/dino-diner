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
    /// Interaction logic for DinoNuggetsSelection.xaml
    /// </summary>
    public partial class DinoNuggetsSelection : Page
    {
        private DinoNuggets dinoNuggets;

        private bool isEdit;
        /// <summary>
        /// Initialize the DinoNuggetsSelection page.
        /// </summary>
        public DinoNuggetsSelection(DinoNuggets dinoNuggets)
        {
            InitializeComponent();
            this.dinoNuggets = dinoNuggets;
            SetUpDinoNuggetsSelection();
        }
        /// <summary>
        /// Initialize the DinoNuggetsSelection page.
        /// </summary>
        public DinoNuggetsSelection(DinoNuggets dinoNuggets, bool isEdit)
        {
            InitializeComponent();
            this.dinoNuggets = dinoNuggets;
            this.isEdit = isEdit;
            SetUpDinoNuggetsSelection();
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
        /// Adds a nugget to the dino-nuggets item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectAddNugget(object sender, RoutedEventArgs args)
        {
            dinoNuggets.AddNugget();
            SetUpDinoNuggetsSelection();
        }
        /// <summary>
        /// Resets the dino-nuggets nugget count.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectResetNuggetCount(object sender, RoutedEventArgs args)
        {
            dinoNuggets.ResetNuggetCount();
            SetUpDinoNuggetsSelection();
        }
        /// <summary>
        /// Prepares the DinoNuggetsSelection user interface.
        /// </summary>
        private void SetUpDinoNuggetsSelection()
        {
            AddNuggetTextBlock.Text = $"Add Nugget ({dinoNuggets.nuggets} Current)";
        }
    }
}
