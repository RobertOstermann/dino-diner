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
        public bool Bun { get; private set; } = true;
        // Indicates the use of a pickle.
        public bool Pickle { get; private set; } = true;
        // Indicates the use of ketchup.
        public bool Ketchup { get; private set; } = true;
        // Indicates the use of mustard.
        public bool Mustard { get; private set; } = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
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
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
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
            Bun = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the pickles.
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            Ketchup = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the mustard.
        /// </summary>
        public void HoldMustard()
        {
            Mustard = false;
            NotifyOfPropertyChange("Special");
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
        /// Adds the pickles.
        /// </summary>
        public void AddPickle()
        {
            Pickle = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the ketchup.
        /// </summary>
        public void AddKetchup()
        {
            Ketchup = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the mustard.
        /// </summary>
        public void AddMustard()
        {
            Mustard = true;
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
