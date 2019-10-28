/* OrderTest.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCostShouldNotBeAbleToBeNegative()
        {
            Order order = new Order();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.Price -= 10;
            order.Add(pbj);
            Assert.Equal(0, order.SubtotalCost, 1);
        }

        [Fact]
        public void PrehistoricPBJEntreeShouldHaveCorrectSubtotalCost()
        {
            Order order = new Order();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            order.Add(pbj);
            Assert.Equal(6.52, order.SubtotalCost, 2);
        }

        [Fact]
        public void PrehistoricPBJEntreeShouldHaveCorrectSalesTaxCost()
        {
            Order order = new Order();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            order.Add(pbj);
            Assert.Equal(0.98, order.SalesTaxCost, 2);
        }

        [Fact]
        public void PrehistoricPBJEntreeShouldHaveCorrectTotalCost()
        {
            Order order = new Order();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            order.Add(pbj);
            Assert.Equal(7.50, order.TotalCost, 2);
        }

        [Fact]
        public void BrontowurstComboShouldHaveCorrectSubtotalCost()
        {
            Order order = new Order();
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            order.Add(combo);
            Assert.Equal(7.60, order.SubtotalCost, 2);
        }

        [Fact]
        public void BrontowurstComboShouldHaveCorrectSalesTaxCost()
        {
            Order order = new Order();
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            order.Add(combo);
            Assert.Equal(1.14, order.SalesTaxCost, 2);
        }

        [Fact]
        public void BrontowurstComboShouldHaveCorrectTotalCost()
        {
            Order order = new Order();
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            order.Add(combo);
            Assert.Equal(8.74, order.TotalCost, 2);
        }
    }
}
