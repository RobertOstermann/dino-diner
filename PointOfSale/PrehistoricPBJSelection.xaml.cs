﻿using System;
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

        private Brush buttonColor = Brushes.SpringGreen;

        public PrehistoricPBJSelection(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Confirms the properties of the pbj.
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
        /// Does not add the PBJ to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCancel(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Adds or removes peanut butter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPeanutButter(object sender, RoutedEventArgs args)
        {
            if (pbj.PeanutButter) pbj.HoldPeanutButter();
            else pbj.AddPeanutButter();
            SetUpEntreeSelection();
        }
        /// <summary>
        /// Adds or removes jelly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectJelly(object sender, RoutedEventArgs args)
        {
            if (pbj.Jelly) pbj.HoldJelly();
            else pbj.AddJelly();
            SetUpEntreeSelection();
        }

        /// <summary>
        /// Prepares the EntreeSelection user interface.
        /// </summary>
        private void SetUpEntreeSelection()
        {
            ClearButtonValues();
            if (pbj.PeanutButter) PeanutButterButton.Background = buttonColor;
            if (pbj.Jelly) JellyButton.Background = buttonColor;
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            PeanutButterButton.ClearValue(Control.BackgroundProperty);
            JellyButton.ClearValue(Control.BackgroundProperty);
        }
    }
}
