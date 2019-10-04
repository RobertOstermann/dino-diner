using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        // Indicates the use of a bun.
        private bool bun = true;
        // Indicates the use of a pickle.
        private bool pickle = true;
        // Indicates the use of ketchup.
        private bool ketchup = true;
        // Indicates the use of mustard.
        private bool mustard = true;
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
        }
        /// <summary>
        /// Removes the pickles.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }
        /// <summary>
        /// Removes the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }
        /// <summary>
        /// Removes the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }
    }
}
