using System.Collections.Generic;
using csharp.Items;
using NUnit.Framework;

namespace csharp.UnitTests
{
    [TestFixture]
    public class GildedRoseAgedBrieItemTests
    {
        readonly AgedBrieItem _test_aged_brie = new AgedBrieItem(2, 0);

        [Test]
        public void After_daily_update_SellIn_value_for_aged_brie_items_goes_down_by_one()
        {
            // Arrange
            int initial_sellin_value = 10;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(initial_sellin_value, 20) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_sellin_value - 1, self_managing_items[0].SellIn);
        }

        [Test]
        public void After_daily_update_Quality_value_for_aged_brie_goes_up_by_one()
        {
            // Arrange
            int initial_quality_value = _test_aged_brie.Quality;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(20, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_quality_value + 1, self_managing_items[0].Quality);
        }

        [Test]
        public void Once_the_sell_by_date_has_passed_aged_brie_quality_goes_up_by_two_each_day()
        {
            // Arrange
            int initial_quality_value = _test_aged_brie.Quality;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(-2, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_quality_value + 2, self_managing_items[0].Quality);
        }

        [Test]
        public void Once_the_sell_by_date_has_passed_aged_brie_quality_will_not_go_above_50()
        {
            // Arrange
            int initial_quality_value = 50;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(-2, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality <= 50);
        }

        [Test]
        public void The_quality_of_aged_brie_items_never_goes_above_50()
        {
            // Arrange
            int initial_quality_value = 50;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(10, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality <= 50);
        }

        [TestCase(10)]
        [TestCase(-2)]
        public void The_quality_of_an_aged_brie_item_is_never_negative(int sellin)
        {
            // Arrange
            int initial_quality_value = 0;
            IList<IItem> self_managing_items = new List<IItem> { new AgedBrieItem(sellin, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality >= 0);
        }
    }
}
