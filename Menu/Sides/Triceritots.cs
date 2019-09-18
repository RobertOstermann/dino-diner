using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Initializes the Triceritots side.
        /// </summary>
        public Triceritots()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 352;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }
        /// <summary>
        /// Gets and sets the size.
        /// Alters the price and calories according to size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (value == Size.Small)
                {
                    Price = 0.99;
                    Calories = 352;
                }
                if (value == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 410;
                }
                if (value == Size.Large)
                {
                    Price = 1.95;
                    Calories = 590;
                }
            }
        }
    }
}
