using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Gets the calories.
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
