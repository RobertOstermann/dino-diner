using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;
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
                    this.Price = 0.99;
                    this.Calories = 222;
                }
                if (size == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 365;
                }
                if (size == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 480;
                }
            }
        }
    }
}
