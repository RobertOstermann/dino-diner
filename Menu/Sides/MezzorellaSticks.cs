using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Initializes the Mezzorella Sticks side.
        /// </summary>
        public MezzorellaSticks()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories =540;
            Ingredients.Add("Breading");
            Ingredients.Add("Cheese Product");
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
                    Calories = 540;
                }
                if (value == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 610;
                }
                if (value == Size.Large)
                {
                    Price = 1.95;
                    Calories = 720;
                }
            }
        }
    }
}
