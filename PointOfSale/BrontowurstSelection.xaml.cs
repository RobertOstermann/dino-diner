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

        public BrontowurstSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prepares the BrontowurstSelection user interface.
        /// </summary>
        private void SetUpBrontowurstSelection()
        {
            ClearButtonValues();
            
        }
        /// <summary>
        /// Resets the button values.
        /// </summary>
        private void ClearButtonValues()
        {
            BunButton.ClearValue(Control.BackgroundProperty);
            PeppersButton.ClearValue(Control.BackgroundProperty);
            OnionButton.ClearValue(Control.BackgroundProperty);
        }
    }
}
