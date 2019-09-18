using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
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
        /// Initializes the DinoNuggets entree.
        /// </summary>
        public DinoNuggets()
        {
            this.nuggets = 6;
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }
        /// <summary>
        /// Adds a dinonugget.
        /// </summary>
        public void AddNugget()
        {
            this.nuggets += 1;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
