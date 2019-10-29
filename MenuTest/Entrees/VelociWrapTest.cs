/* VelociWrapTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains("Flour Tortilla", ingredients);
            Assert.Contains("Chicken Breast", ingredients);
            Assert.Contains("Romaine Lettuce", ingredients);
            Assert.Contains("Ceasar Dressing", ingredients);
            Assert.Contains("Parmesan Cheese", ingredients);
            Assert.Equal(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void HoldDressingShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void HoldCheeseShouldNotifyOfSpecialPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void ShouldHaveHoldDressingWhenHoldingDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldLettuceWhenHoldingLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldCheeseWhenHoldingCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldDressingAndHoldLettuceWhenHoldingDressingAndLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldDressingAndHoldCheeseWhenHoldingDressingAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldCheese();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldLettuceAndHoldCheeseWhenHoldingLettuceAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldDressingAndHoldLettuceAndHoldCheeseWhenHoldingDressingAndLettuceAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Collection(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }
    }
}
