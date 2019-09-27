using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        private Size size;

        /// <summary>
        /// Gets the ingredients of the side.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
            }
        }
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
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.99;
                    Calories = 540;
                }
                if (size == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 610;
                }
                if (size == Size.Large)
                {
                    Price = 1.95;
                    Calories = 720;
                }
            }
        }
    }
}
