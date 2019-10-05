using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        // Indicates the use of peanut butter.
        private bool peanutButter = true;
        // Indicates the use of jelly.
        private bool jelly = true;
        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes the PBJ entree.
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Removes the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
        }
        /// <summary>
        /// Removes the jelly.
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
