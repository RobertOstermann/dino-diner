/* Brontowurst.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Gets the bun value.
        /// </summary>
        public bool Bun { get; private set; } = true;
        /// <summary>
        /// Gets the peppers value.
        /// </summary>
        public bool Peppers { get; private set; } = true;
        /// <summary>
        /// Gets the onions value.
        /// </summary>
        public bool Onions { get; private set; } = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Gets preparation instructions for the entree.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Initializes the Brontowurst entree.
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Adds the bun.
        /// </summary>
        public void AddBun()
        {
            Bun = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the peppers.
        /// </summary>
        public void AddPeppers()
        {
            Peppers = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the onions.
        /// </summary>
        public void AddOnion()
        {
            Onions = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the bun.
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            Peppers = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the onions.
        /// </summary>
        public void HoldOnion()
        {
            Onions = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
