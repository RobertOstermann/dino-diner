/* TRexKingBurgerTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal(3, count);
            Assert.Contains("Lettuce", ingredients);
            Assert.Contains("Tomato", ingredients);
            Assert.Contains("Onion", ingredients);
            Assert.Contains("Pickle", ingredients);
            Assert.Contains("Ketchup", ingredients);
            Assert.Contains("Mustard", ingredients);
            Assert.Contains("Mayo", ingredients);
            Assert.Equal(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain("Mayo", trex.Ingredients);
        }

        [Fact]
        public void AddBunShouldAddBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.AddBun();
            Assert.Contains("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void AddLettuceShouldAddLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            trex.AddLettuce();
            Assert.Contains("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void AddTomatoShouldAddTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            trex.AddTomato();
            Assert.Contains("Tomato", trex.Ingredients);
        }

        [Fact]
        public void AddOnionShouldAddOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            trex.AddOnion();
            Assert.Contains("Onion", trex.Ingredients);
        }

        [Fact]
        public void AddPickleShouldAddPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            trex.AddPickle();
            Assert.Contains("Pickle", trex.Ingredients);
        }

        [Fact]
        public void AddKetchupShouldAddKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            trex.AddKetchup();
            Assert.Contains("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void AddMustardShouldAddMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            trex.AddMustard();
            Assert.Contains("Mustard", trex.Ingredients);
        }

        [Fact]
        public void AddMayoShouldAddMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            trex.AddMayo();
            Assert.Contains("Mayo", trex.Ingredients);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
        }

        [Fact]
        public void HoldTomatoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldOnion();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
        }

        [Fact]
        public void HoldMayoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
        }

        [Fact]
        public void AddBunShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddBun();
            });
        }

        [Fact]
        public void AddLettuceShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddLettuce();
            });
        }

        [Fact]
        public void AddTomatoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddTomato();
            });
        }

        [Fact]
        public void AddOnionShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddOnion();
            });
        }

        [Fact]
        public void AddPickleShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddPickle();
            });
        }

        [Fact]
        public void AddKetchupShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddKetchup();
            });
        }

        [Fact]
        public void AddMustardShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddMustard();
            });
        }

        [Fact]
        public void AddMayoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.AddMayo();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);
        }

        [Fact]
        public void ShouldHaveHoldBunWhenHoldingBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldLettuceWhenHoldingLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldTomateWhenHoldingTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldOnionWhenHoldingOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldPickleWhenHoldingPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldKetchupWhenHoldingKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldMustardWhenHoldingMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldMayoWhenHoldingMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void ShouldHoldEachItemsWhenHoldingEachItem()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldMustard();
            trex.HoldMayo();
            Assert.Collection(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }
        //Tests do not cover all permutation of the Special options.
    }

}
