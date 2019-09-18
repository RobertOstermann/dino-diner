using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
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
                return this.Size;
            }
            set
            {
                this.Size = value;
                if (value == Size.Small)
                {
                    Price = 0.99;
                    Calories = 420;
                }
                if (value == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 490;
                }
                if (value == Size.Large)
                {
                    Price = 1.95;
                    Calories = 520;
                }
            }
        }
    }
}
