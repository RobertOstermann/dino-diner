/* Drink.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// Gets and sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets and sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the ice.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Sets the Ice property to false.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
