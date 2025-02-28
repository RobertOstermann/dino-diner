﻿/* WaterTest.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void AddIceShouldAddIce()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddIce();
            Assert.True(water.Ice);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            List<string> ingredients = water.Ingredients;
            Assert.Contains("Lemon", ingredients);
        }

        [Fact]
        public void RemoveLemonShouldRemoveLemon()
        {
            Water water = new Water();
            water.AddLemon();
            water.RemoveLemon();
            Assert.False(water.Lemon);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = size;
            });
        }

        [Fact]
        public void HoldIceShouldNotifyOfSpecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddIce();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void ShouldHaveHoldIceWhenHoldingIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }

    }
}
