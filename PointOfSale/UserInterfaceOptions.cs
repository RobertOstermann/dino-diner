using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class UserInterfaceOptions
    {
        public static Brush SelectedColor { get; } = Brushes.SpringGreen;

        public static Brush BaseColor { get; } = Brushes.Gainsboro;

        public static Thickness SelectedThickness { get; } = new Thickness(2);

        public static Thickness BaseThickness { get; } = new Thickness(1);
    }
}
