using System.Collections.Generic;
using csharp.Items;
using NUnit.Framework;

namespace csharp.UnitTests
{
    [TestFixture]
    public class GildedRoseBackstagePassItemTests
    {
        [Test]
        public void After_daily_update_SellIn_value_for_backstage_pass_items_goes_down_by_one()
        {
            // Arrange
            int initial_sellin_value = 10;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem(" to a TAFKAL80ETC concert", initial_sellin_value, 20) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(initial_sellin_value - 1, self_managing_items[0].SellIn);
        }

        [Test]
        public void The_quality_of_backstage_pass_items_never_goes_above_50()
        {
            // Arrange
            int initial_quality_value = 50;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem(" to a TAFKAL80ETC concert", 10, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality <= 50);
        }

        [TestCase(10)]
        [TestCase(-2)]
        public void The_quality_of_a_backstage_pass_item_is_never_negative(int sellin)
        {
            // Arrange
            int initial_quality_value = 0;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem(" to a Jungle Boys concert", sellin, initial_quality_value) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.IsTrue(self_managing_items[0].Quality >= 0);
        }

        [TestCase(50)]
        [TestCase(30)]
        [TestCase(11)]
        public void After_daily_update_Quality_value_for_backstage_pass_goes_up_by_one_if_more_than_ten_days_to_go(int sellin)
        {
            // Arrange
            const int InitialQualityValue = 10;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem("to Prince", sellin, InitialQualityValue) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(InitialQualityValue + 1, self_managing_items[0].Quality);
        }

        [TestCase(10)]
        [TestCase(9)]
        [TestCase(8)]
        [TestCase(7)]
        [TestCase(6)]
        public void Quality_of_backstage_pass_increases_by_two_each_day_between_ten_days_and_six_days_before_concert_date(int sellin)
        {
            // Arrange
            const int InitialQualityValue = 10;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem("to Madonna", sellin, InitialQualityValue) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(InitialQualityValue + 2, self_managing_items[0].Quality);
        }

        [TestCase(5)]
        [TestCase(4)]
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(1)]
        public void Quality_of_backstage_pass_increases_by_three_each_day_five_days_or_less_before_concert_date(int sellin)
        {
            // Arrange
            const int InitialQualityValue = 10;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem("to the Alabama 3", sellin, InitialQualityValue) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(InitialQualityValue + 3, self_managing_items[0].Quality);
        }

        [Test]
        public void Quality_of_backstage_pass_drops_to_zero_after_concert_date()
        {
            // Arrange
            const int InitialQualityValue = 10;
            const int PastConcertDate = 0;
            IList<IItem> self_managing_items = new List<IItem> { new BackstagePassItem("to Fontaines DC", PastConcertDate, InitialQualityValue) };
            GildedRose app = new GildedRose(self_managing_items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(0, self_managing_items[0].Quality);
        }
    }
}
