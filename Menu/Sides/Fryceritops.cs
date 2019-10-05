using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        private Size size;
        /// <summary>
        /// Gets the ingredients of the side.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Initializes the Fryceritop side.
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 222;
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
                    Price = 0.99;
                    Calories = 222;
                }
                if (size == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 365;
                }
                if (size == Size.Large)
                {
                    Price = 1.95;
                    Calories = 480;
                }
            }
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return $"{Size} Friceritops";
        }
    }
}
