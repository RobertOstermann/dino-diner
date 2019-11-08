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
        /// <summary>
        /// Gets the nuggets value.
        /// </summary>
        public int Nuggets { get; private set; }
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < Nuggets; i++)
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
                if (Nuggets > 6)
                {
                    int i = Nuggets - 6;
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
            Nuggets = 6;
            Price = 4.25;
            Calories = 59 * 6;
        }
        /// <summary>
        /// Adds a dinonugget.
        /// </summary>
        public void AddNugget()
        {
            Nuggets += 1;
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
        }
        /// <summary>
        /// Resets the entree.
        /// </summary>
        public void ResetNuggetCount()
        {
            Nuggets = 6;
            Price = 4.25;
            Calories = 59 * 6;
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
