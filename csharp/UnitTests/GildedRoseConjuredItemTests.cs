using System.Collections.Generic;
using csharp.Items;
using NUnit.Framework;

namespace csharp.UnitTests
{
    [TestFixture]
    public class GildedRoseConjuredItemTests
    {
        readonly ConjuredItem _test_conjured_item_01 = new ConjuredItem(10, 20);
        readonly ConjuredItem _test_conjured_item_02 = new ConjuredItem(5, 7);

        [Test]
        public void After_daily_update_SellIn_value_for_conjured_items_goes_down_by_one()
        {
            // Arrange
            int initial_sellin_value = 10;
            IList<IItem> self_managing_items = new List<IItem> { new ConjuredItem(initial_sellin_value, 20) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_sellin_value - 1, self_managing_items[0].SellIn);
        }

        [Test]
        public void After_daily_update_Quality_value_for_conjured_items_goes_down_by_two()
        {
            // Arrange
            int initial_quality_value_01 = _test_conjured_item_01.Quality;
            int initial_quality_value_02 = _test_conjured_item_02.Quality;
            IList<IItem> self_managing_items = new List<IItem> { _test_conjured_item_01, _test_conjured_item_02 };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_quality_value_01 - 2, self_managing_items[0].Quality);
            Assert.AreEqual(initial_quality_value_02 - 2, self_managing_items[1].Quality);
        }

        [Test]
        public void The_quality_of_conjured_items_never_goes_above_50()
        {
            // Arrange
            int initial_quality_value = 50;
            IList<IItem> self_managing_items = new List<IItem> { new ConjuredItem(10, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality <= 50);
        }

        [TestCase(10)]
        [TestCase(-2)]
        public void The_quality_of_a_conjured_item_is_never_negative(int sellin)
        {
            // Arrange
            int initial_quality_value = 0;
            IList<IItem> self_managing_items = new List<IItem> { new ConjuredItem(sellin, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality >= 0);
        }

        [Test]
        public void Once_a_sell_by_date_is_passed_the_quality_of_conjured_items_decreases_by_four_per_day()
        {
            // Arrange
            const int InitialQualityValue = 10;
            const int PastSellByDate = 0;
            IList<IItem> self_managing_items = new List<IItem> { new ConjuredItem(PastSellByDate, InitialQualityValue) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(InitialQualityValue - 4, self_managing_items[0].Quality);
        }
    }
}
