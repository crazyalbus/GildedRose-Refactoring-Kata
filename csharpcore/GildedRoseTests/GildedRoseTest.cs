using System;
using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;

namespace GildedRoseTests
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality()
        {
            var itemString = DoUpdateQuality("foo", 0, 0);
            
            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new String[] { 
                    "foo", 
                    "Aged Brie", 
                    "Backstage passes to a TAFKAL80ETC concert", 
                    "Sulfuras, Hand of Ragnaros" },
                new int[] { 0 },
                new int[] { 0 });
        }

        private string DoUpdateQuality(string name, int sellIn, int quality)
        {
            Item item = new Item { Name = name, SellIn = sellIn, Quality = quality };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            string itemString = Items[0].ToString();
            return itemString;
        }
    }
}

/*
using ApprovalTests;

    [UseReporter(typeof(DiffReporter))]
using ApprovalTests.Reporters;

            Assert.Equal("foo", Items[0].Name);
            
            Approvals.Verify(Items[0].Name);
            
            Approvals.Verify(Items[0].ToString());
            
            CombinationApprovals.VerifyAllCombinations();
            
            string itemString = Items[0].ToString();
            Approvals.Verify(itemString);
            
            var item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            
            var name = "foo";
            var sellIn = 0;
            var quality = 0;
            var item = new Item { Name = name, SellIn = sellIn, Quality = quality };
            
            // EXTRACT METHOD
            var item = new Item { Name = name, SellIn = sellIn, Quality = quality };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            string itemString = Items[0].ToString();            
            
            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new String[] { name },
                new int[] { sellIn },
                new int[] { quality });
            
            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new String[] { name, "Aged Brie" },
                new int[] { sellIn },
                new int[] { quality });
            
            CombinationApprovals.VerifyAllCombinations(
                DoUpdateQuality,
                new String[] { "foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" },
                new int[] { -1, 0, 2, 6, 11 },
                new int[] { 0, 1, 49, 50 });
                
        
        private String DoUpdateQuality(String name, int sellin, int quality)
        {
            Item[] items = new Item[] {
                new Item
                {
                    Name = name,
                    SellIn = sellin,
                    Quality = quality
                } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            return items[0].ToString();
        }
 */
