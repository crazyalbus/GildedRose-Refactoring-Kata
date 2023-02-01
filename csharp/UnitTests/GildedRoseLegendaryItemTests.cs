using System.Collections.Generic;
using csharp.Items;
using NUnit.Framework;

namespace csharp.UnitTests
{
    [TestFixture]
    public class GildedRoseLegendaryItemTests
    {
        readonly LegendaryItem _test_sulfuras_01 = new LegendaryItem(0, 80);

        [Test]
        public void After_daily_update_SellIn_value_for_sulfuras_remains_the_same()
        {
            // Arrange
            int initial_sellin_value = _test_sulfuras_01.SellIn;
            IList<IItem> self_managing_items = new List<IItem> { _test_sulfuras_01 };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_sellin_value, self_managing_items[0].SellIn);
        }

        [Test]
        public void After_daily_update_Quality_value_for_sulfuras_remains_the_same()
        {
            // Arrange
            int initial_quality_value = _test_sulfuras_01.Quality;
            IList<IItem> self_managing_items = new List<IItem> { _test_sulfuras_01 };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_quality_value, self_managing_items[0].Quality);
        }

        [TestCase(10)]
        [TestCase(-2)]
        public void The_quality_of_a_legendary_item_is_never_negative(int sellin)
        {
            // Arrange
            int initial_quality_value = 0;
            IList<IItem> self_managing_items = new List<IItem> { new LegendaryItem(sellin, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality >= 0);
        }
    }
}
