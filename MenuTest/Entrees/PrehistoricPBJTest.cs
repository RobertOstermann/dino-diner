/* PrehistoricPBJTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains("Bread", ingredients);
            Assert.Contains("Peanut Butter", ingredients);
            Assert.Contains("Jelly", ingredients);
            Assert.Equal(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void AddPeanutButterShouldAddPeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            pbj.AddPeanutButter();
            Assert.Contains("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void AddJellyShouldAddJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            pbj.AddJelly();
            Assert.Contains("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void HoldPeanutButterShouldNotifyOfSpecialPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }

        [Fact]
        public void AddPeanutButterShouldNotifyOfSpecialPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.AddPeanutButter();
            });
        }

        [Fact]
        public void HoldJellyShouldNotifyOfSpecialPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }

        [Fact]
        public void AddJellyShouldNotifyOfSpecialPropertyChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.AddJelly();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void ShouldHaveHoldPeanutButterWhenHoldingPeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.Collection(pbj.Special, 
                item =>
                {
                    Assert.Equal("Hold Peanut Butter", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldJellyWhenHoldingJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Collection(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Jelly", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveHoldPeanutButterAndHoldJellyWhenHoldingPeanutButterAndHoldingJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            pbj.HoldJelly();
            Assert.Collection(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Peanut Butter", item);
                },
                item =>
                {
                    Assert.Equal("Hold Jelly", item);
                }
            );
        }
    }

}
