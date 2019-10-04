using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        private Size size;

        private bool sweet;
        /// <summary>
        /// Gets and sets the sweetener.
        /// </summary>
        public bool Sweet {
            get
            {
                return sweet;
            }
            set
            {
                if (sweet != value)
                {
                    sweet = value;
                    if (sweet) Calories *= 2;
                    else Calories /= 2;
                }
            }
        }

        /// <summary>
        /// Gets and sets the lemon.
        /// </summary>
        public bool Lemon { get; private set; }
        /// <summary>
        /// Gets the ingredients of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes the Tyrannotea drink.
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 8;
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
                    if (Sweet) Calories = 16;
                    else Calories = 8;
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweet) Calories = 32;
                    else Calories = 16;
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweet) Calories = 64;
                    else Calories = 32;
                }
            }
        }
        /// <summary>
        /// Sets the Lemon property to true.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
