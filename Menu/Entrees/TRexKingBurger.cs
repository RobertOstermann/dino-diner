using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        // Indicates the use of a bun.
        private bool bun = true;
        // Indicates the use of lettuce.
        private bool lettuce = true;
        // Indicates the use of tomato.
        private bool tomato = true;
        // Indicates the use of onion.
        private bool onion = true;
        // Indicates the use of pickle.
        private bool pickle = true;
        // Indicates the use of ketchup.
        private bool ketchup = true;
        // Indicates the use of mustard.
        private bool mustard = true;
        // Indicates the use of mayo.
        private bool mayo = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes the T-Rex King Burger entree. 
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }
        /// <summary>
        /// Removes the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// Removes the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// Removes the tomato.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }
        /// <summary>
        /// Removes the onion.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
        }
        /// <summary>
        /// Removes the pickle.
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
        /// <summary>
        /// Removes the mayo.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
