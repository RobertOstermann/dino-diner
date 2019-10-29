/* BrontowurstTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains("Whole Wheat Bun", ingredients);
            Assert.Contains("Brautwurst", ingredients);
            Assert.Contains("Peppers", ingredients);
            Assert.Contains("Onion", ingredients);
            Assert.Equal(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain("Onion", bw.Ingredients);
        }

        [Fact]
        public void AddBunShouldAddBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.AddBun();
            Assert.Contains("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void AddPeppersShouldAddPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            bw.AddPeppers();
            Assert.Contains("Peppers", bw.Ingredients);
        }

        [Fact]
        public void AddOnionShouldAddOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            bw.AddOnion();
            Assert.Contains("Onion", bw.Ingredients);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
        }

        [Fact]
        public void HoldPeppersShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
        }

        [Fact]
        public void AddBunShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.AddBun();
            });
        }

        [Fact]
        public void AddPeppersShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.AddPeppers();
            });
        }

        [Fact]
        public void AddOnionShouldNotifyOfSpecialPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.AddOnion();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void ShouldHaveHoldBunWhenHoldingBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldPeppersWhenHoldingPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldOnionWhenHoldingOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveBunAndPeppersWhenHoldingBunAndPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveBunAndOnionWhenHoldingBunAndOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }
            );
        }

        [Fact]
        public void ShouldHavePeppersAndOnionWhenHoldingPeppersAndOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            bw.HoldPeppers();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveBunAndPeppersAndOnionWhenHoldingBunAndPeppersAndOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnion();
            Assert.Collection(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }
            );
        }
    }

}
