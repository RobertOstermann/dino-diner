/* PrehistoricPBJ.cs
 * Author: Robert Ostermann
 */
using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        // Indicates the use of peanut butter.
        public bool PeanutButter { get; private set; } = true;
        // Indicates the use of jelly.
        public bool Jelly { get; private set; } = true;

        /// <summary>
        /// Gets the ingredients of the entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets preparation instructions for the entree.
        /// </summary>
        public override string [] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!PeanutButter) special.Add("Hold Peanut Butter");
                if (!Jelly) special.Add("Hold Jelly");
                return special.ToArray();
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
            PeanutButter = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds peanut butter.
        /// </summary>
        public void AddPeanutButter()
        {
            PeanutButter = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Removes the jelly.
        /// </summary>
        public void HoldJelly()
        {
            Jelly = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Adds jelly.
        /// </summary>
        public void AddJelly()
        {
            Jelly = true;
            NotifyOfPropertyChange("Special");
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
