﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// Initializes the Fryceritop side.
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 222;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegtable Oil");
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
                    Calories = 222;
                }
                if (value == Size.Medium)
                {
                    Price = 1.45;
                    Calories = 365;
                }
                if (value == Size.Large)
                {
                    Price = 1.95;
                    Calories = 480;
                }
            }
        }
    }
}
