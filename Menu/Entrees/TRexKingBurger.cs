/* TRexKingBurger.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        // Indicates the use of a bun.
        public bool Bun { get; private set; } = true;
        // Indicates the use of lettuce.
        public bool Lettuce { get; private set; } = true;
        // Indicates the use of tomato.
        public bool Tomato { get; private set; } = true;
        // Indicates the use of onion.
        public bool Onion { get; private set; } = true;
        // Indicates the use of pickle.
        public bool Pickle { get; private set; } = true;
        // Indicates the use of ketchup.
        public bool Ketchup { get; private set; } = true;
        // Indicates the use of mustard.
        public bool Mustard { get; private set; } = true;
        // Indicates the use of mayo.
        public bool Mayo { get; private set; } = true;
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
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
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
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Onion) special.Add("Hold Onion");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Mayo) special.Add("Hold Mayo");
                return special.ToArray();
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
            Bun = false;
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
        /// Removes the tomato.
        /// </summary>
        public void HoldTomato()
        {
            Tomato = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the onion.
        /// </summary>
        public void HoldOnion()
        {
            Onion = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the pickle.
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
        /// Removes the mayo.
        /// </summary>
        public void HoldMayo()
        {
            Mayo = false;
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
        /// Adds the lettuce.
        /// </summary>
        public void AddLettuce()
        {
            Lettuce = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the tomato.
        /// </summary>
        public void AddTomato()
        {
            Tomato = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the onion.
        /// </summary>
        public void AddOnion()
        {
            Onion = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the pickle.
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
        /// Removes the mustard.
        /// </summary>
        public void AddMustard()
        {
            Mustard = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds the mayo.
        /// </summary>
        public void AddMayo()
        {
            Mayo = true;
            NotifyOfPropertyChange("Special");
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
