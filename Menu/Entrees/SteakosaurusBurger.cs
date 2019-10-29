/* SteakosaurusBurger.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        // Indicates the use of a bun.
        public bool bun { get; private set; } = true;
        // Indicates the use of a pickle.
        public bool pickle { get; private set; } = true;
        // Indicates the use of ketchup.
        public bool ketchup { get; private set; } = true;
        // Indicates the use of mustard.
        public bool mustard { get; private set; } = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
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
                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Initializes the Steakosaurus Burger entree.
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// Removes the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the pickles.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds the bun.
        /// </summary>
        public void AddBun()
        {
            bun = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the pickles.
        /// </summary>
        public void AddPickle()
        {
            pickle = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the ketchup.
        /// </summary>
        public void AddKetchup()
        {
            ketchup = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the mustard.
        /// </summary>
        public void AddMustard()
        {
            mustard = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
