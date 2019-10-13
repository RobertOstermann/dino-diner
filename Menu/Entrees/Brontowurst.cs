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
        // Indicates the use of a bun.
        private bool bun = true;
        // Indicates the use of peppers.
        private bool peppers = true;
        // Indicates the use of onions.
        private bool onions = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
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
        /// Removes the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// Removes the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
        }
        /// <summary>
        /// Removes the onions.
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
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
