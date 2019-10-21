/* Order.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Represents the items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Calculates the price of all order items.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;
                foreach (IOrderItem i in Items)
                {
                    subtotalCost += i.Price;
                }
                if (subtotalCost < 0) subtotalCost = 0;
                return subtotalCost;
            }
        }
        /// <summary>
        /// Gets and sets the sales tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.15;
        /// <summary>
        /// Calculates the sales tax.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }
        /// <summary>
        /// Calculates the total cost of the order.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
