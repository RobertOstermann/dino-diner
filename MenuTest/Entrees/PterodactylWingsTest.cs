﻿/* PterodactylWingsTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains("Chicken", ingredients);
            Assert.Contains("Wing Sauce", ingredients);
            Assert.Equal(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }
    }
}
