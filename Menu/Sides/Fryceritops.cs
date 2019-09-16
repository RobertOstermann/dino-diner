using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// Initializes the Fryceritop side.
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 222;
            Ingredients.Add("Potatos");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegtable Oil");
        }
    }
}
