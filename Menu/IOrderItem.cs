/* IOrderItem.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Gets the calories.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        string [] Special { get; }
    }
}
