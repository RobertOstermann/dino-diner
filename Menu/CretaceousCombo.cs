using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree;
        public Drink Drink;
        public Side Side;

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the combo.
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }
        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - 0.25;
            }
        }
        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Drink.Calories + Side.Calories;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
