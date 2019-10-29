/* TyrannoteaTest.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
            Assert.Equal(2, tea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(Size.Medium, tea.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(Size.Large, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void AddIceShouldAddIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddIce();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains("Lemon", ingredients);
        }

        [Fact]
        public void RemoveLemonShouldRemoveLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.RemoveLemon();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void AddSweetShouldAddCaneSugar()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            List<string> ingredients = tea.Ingredients;
            Assert.Contains("Cane Sugar", ingredients);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<uint>(64, tea.Calories);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetToNotSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetToNotSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSweetToNotSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeShouldNotifyOfPricePropertyChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = size;
            });
        }

        [Fact]
        public void AddLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void AddSweetShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.Sweet = true;
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void ShouldHaveHoldIceWhenHoldingIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveAddLemonWhenAddingLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldIceAndAddLemonWhenHoldingIceAndAddingLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddLemon();
            Assert.Collection(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }
    }
}
