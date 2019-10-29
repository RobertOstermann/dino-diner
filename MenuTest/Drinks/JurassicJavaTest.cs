/* JurassicJavaTest.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(0.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngedients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
            Assert.Equal(2, java.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(0.99, java.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(Size.Medium, java.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(Size.Large, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultNoIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultNoSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            JurassicJava java = new JurassicJava();
            java.HoldIce();
            Assert.False(java.Ice);
        }

        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        [Fact]
        public void LeaveSpaceForCreamShouldAddSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void RemoveSpaceForCreamShouldRemoveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.RemoveRoomForCream();
            Assert.False(java.RoomForCream);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeShouldNotifyOfPricePropertyChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeShouldNotifyOfDescriptionPropertyChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = size;
            });
        }

        [Fact] 
        public void LeaveRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void RemoveRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.RemoveRoomForCream();
            });
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void HoldIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.HoldIce();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void ShouldHaveAddIceWhenAddingIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveRoomForCreamWhenLeavingRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection(java.Special,
                item =>
                {
                    Assert.Equal("Room for Cream", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveAddIceAndRoomForCreamWhenAddingIceAndLeavingRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            Assert.Collection(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Room for Cream", item);
                }
            );
        }
    }
}
