using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        private Size size;

        /// <summary>
        /// Gets the ingredients of the side.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }
        /// <summary>
        /// Initializes the MeteorMacAndCheese side.
        /// </summary>
        public MeteorMacAndCheese()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
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
                    Calories = 420;
                }
                if (size == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 490;
                }
                if (size == Size.Large)
                {
                    Price = 1.95;
                    Calories = 520;
                }
            }
        }
    }
}
