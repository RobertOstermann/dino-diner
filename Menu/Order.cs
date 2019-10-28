/* Order.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for the property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Backing variable
        List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Represents the items added to the order.
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
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
                return Math.Max(subtotalCost, 0);
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

        public Order()
        {
            //Items = new ObservableCollection<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            NotifyOfAllPropertyChanged();
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                item.PropertyChanged += OnPropertyChanged;
                NotifyOfAllPropertyChanged();
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfAllPropertyChanged();
        }

        protected void NotifyOfAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
