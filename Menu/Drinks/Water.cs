/* Water.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        private Size size;

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
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
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
        public Water()
        {
            Size = Size.Small;
            Price = 0.10;
            Calories = 0;
        }
        /// <summary>
        /// Gets and sets the size.
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
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Sets the Lemon property to true.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
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
            return $"{Size} Water";
        }
    }
}
