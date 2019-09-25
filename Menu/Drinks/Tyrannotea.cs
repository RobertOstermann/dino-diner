﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        /// <summary>
        /// Gets and sets the sweetener.
        /// </summary>
        public bool Sweet { get; set; }
        /// <summary>
        /// Gets and sets the lemon.
        /// </summary>
        public bool Lemon { get; set; }
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
        /// Initializes the Sodasaurus drink.
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 8;
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
                    if (this.Sweet) this.Calories = 16;
                    else this.Calories = 8;
                }
                if (size == Size.Medium)
                {
                    this.Price = 2.00;
                    if (this.Sweet) this.Calories = 32;
                    else this.Calories = 16;
                }
                if (size == Size.Large)
                {
                    this.Price = 2.50;
                    if (this.Sweet) this.Calories = 64;
                    else this.Calories = 32;
                }
            }
        }
    }
}
