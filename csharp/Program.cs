using System;
using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            Use_self_managing_items();
        }

        private static void Use_self_managing_items()
        {
            IList<IItem> self_managing_items = new List<IItem>
            {
                new RegularItem ("+5 Dexterity Vest", 10, 20),
                new AgedBrieItem (2, 0),
                new RegularItem ("Elixir of the Mongoose", 5, 7),
                new LegendaryItem (0, 80),
                new LegendaryItem (-1, 80),
                new BackstagePassItem (" to a TAFKAL80ETC concert", 15, 20),
                new BackstagePassItem (" to a Bob Marley concert", 10, 49),
                new BackstagePassItem (" to a Jungle Boys concert", 5, 49),
                // this conjured item does not work properly yet
                new ConjuredItem (3, 20)
            };

            var app = new GildedRose(self_managing_items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < self_managing_items.Count; j++)
                {
                    System.Console.WriteLine(self_managing_items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
