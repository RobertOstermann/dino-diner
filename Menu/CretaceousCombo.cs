/* CretaceousCombo.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        private Size size = Size.Small;

        private Entree entree;

        private Drink drink;

        private Side side;
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes
        /// to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of property changes.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets and sets the entree.
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// Gets and sets the size of the combo.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
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
        /// <summary>
        /// Gets the ingredients of the combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Gets a description of the combo.
        /// </summary>
        public string Description
        {
            get
            {
                return ToString();
            }
        }
        /// <summary>
        /// Gets the preparation instruction for the combo.
        /// </summary>
        public string [] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add("-----SIDE-----");
                special.Add(Side.ToString());
                special.AddRange(Side.Special);
                special.Add("-----DRINK-----");
                special.Add(Drink.ToString());
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// Initializes the CretaceousCombo.
        /// </summary>
        /// <param name="entree">Entree chosen by the customer.</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns>Name of the item.</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}
