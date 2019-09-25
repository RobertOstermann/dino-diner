using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            this.Size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;
        }
        /// <summary>
        /// Gets and sets the size.
        /// Alters the price and calories according to size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                if (size == Size.Small)
                {
                    this.Price = 1.50;
                    this.Calories = 112;
                }
                if (size == Size.Medium)
                {
                    this.Price = 2.00;
                    this.Calories = 156;
                }
                if (size == Size.Large)
                {
                    this.Price = 2.50;
                    this.Calories = 208;
                }
            }
        }
    }
}
