/* Tyrannotea.cs
 * Author: Robert Ostermann
 */
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
                    NotifyOfPropertyChange("Special");
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
        /// Gets the preparation instruction for the drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
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
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweet) Calories = 32;
                    else Calories = 16;
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweet) Calories = 64;
                    else Calories = 32;
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
            }
        }
        /// <summary>
        /// Sets the Lemon property to true.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the Lemon property to false.
        /// </summary>
        public void RemoveLemon()
        {
            Lemon = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            if (Sweet) return $"{Size} Sweet Tyrannotea";
            else return $"{Size} Tyrannotea";
        }
    }
}
