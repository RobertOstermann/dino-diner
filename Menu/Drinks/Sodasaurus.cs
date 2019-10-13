/* Sodasaurus.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        private Size size;
        /// <summary>
        /// Gets and sets the flavor of the drink.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; } = SodasaurusFlavor.Cola;

        /// <summary>
        /// Gets the ingredients of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }
        /// <summary>
        /// Initializes the Sodasaurus drink.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Price = 1.50;
            Calories = 112;
        }
        /// <summary>
        /// Gets and sets the size.
        /// Alters the price and calories according to size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
