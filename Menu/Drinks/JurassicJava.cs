/* JurassicJava.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        private Size size;

        /// <summary>
        /// Gets and sets the room for cream.
        /// </summary>
        public bool RoomForCream { get; private set; }
        /// <summary>
        /// Gets and sets the decaf.
        /// </summary>
        public bool Decaf { get; set; }
        /// <summary>
        /// Gets the ingredients of the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// Gets the preparation instruction for the drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Room for Cream");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Initializes the Tyrannotea drink.
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
            Price = 0.59;
            Calories = 2;
        }
        /// <summary>
        /// Gets and sets the size.
        /// Alters the price and calories according to size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
                if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
                if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                    NotifyOfPropertyChange("Price");
                    NotifyOfPropertyChange("Description");
                }
            }
        }
        /// <summary>
        /// Sets the room for cream property to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Sets the ice property to true.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Jurassic Java";
            else return $"{Size} Jurassic Java";
        }
    }
}
