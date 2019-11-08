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
        /// <summary>
        /// Gets the dressing value.
        /// </summary>
        public bool Dressing { get; private set; } = true;
        /// <summary>
        /// Gets the lettuce value.
        /// </summary>
        public bool Lettuce { get; private set; } = true;
        /// <summary>
        /// Gets the cheese value.
        /// </summary>
        public bool Cheese { get; private set; } = true;
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
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
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
                if (!Dressing) special.Add("Hold Dressing");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Cheese) special.Add("Hold Cheese");
                return special.ToArray();
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
        /// Adds the dressing.
        /// </summary>
        public void AddDressing()
        {
            Dressing = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the lettuce.
        /// </summary>
        public void AddLettuce()
        {
            Lettuce = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the cheese.
        /// </summary>
        public void AddCheese()
        {
            Cheese = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the dressing.
        /// </summary>
        public void HoldDressing()
        {
            Dressing = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the cheese.
        /// </summary>
        public void HoldCheese()
        {
            Cheese = false;
            NotifyOfPropertyChange("Special");
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
