/* DinoNuggets.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        // Indicates the amount of nuggets.
        private int nuggets;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
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
                if (nuggets > 6)
                {
                    int i = nuggets - 6;
                    special.Add($"Add {i} Nuggets");
                }
                return special.ToArray();
            }
        }
        /// <summary>
        /// Initializes the DinoNuggets entree.
        /// </summary>
        public DinoNuggets()
        {
            nuggets = 6;
            Price = 4.25;
            Calories = 59 * 6;
        }
        /// <summary>
        /// Adds a dinonugget.
        /// </summary>
        public void AddNugget()
        {
            nuggets += 1;
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
