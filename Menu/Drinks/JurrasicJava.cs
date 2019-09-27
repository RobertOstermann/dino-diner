﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
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
        /// Initializes the Tyrannotea drink.
        /// </summary>
        public JurrasicJava()
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
                }
                if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }
        /// <summary>
        /// Sets the room for cream property to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// Sets the ice property to true.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

    }
}
