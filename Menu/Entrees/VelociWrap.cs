/* VelociWrap.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        // Indicates the use of dressing.
        private bool dressing = true;
        // Indicates the use of lettuce.
        private bool lettuce = true;
        // Indicates the use of cheese.
        private bool cheese = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes the Veloci Wrap entree.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// Removes the dressing.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }
        /// <summary>
        /// Removes the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// Removes the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
