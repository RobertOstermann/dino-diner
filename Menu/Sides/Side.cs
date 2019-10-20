/* Side.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes.
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets and sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the desription of the side.
        /// </summary>
        public string Description
        {
            get
            {
                return ToString();
            }
        }
        /// <summary>
        /// Gets the preparation instruction for the side.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets and sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
