using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                DoUpdateQuality(Items[i]);
            }
        }

        private static void DoUpdateQuality(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
            else
            {
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }

                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0)
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    var isSulfuras = item.Name == "Sulfuras, Hand of Ragnaros";
                    if (isSulfuras)
                    {
                        if (item.Quality > 0)
                        {
                        }

                        if (item.SellIn < 0)
                        {
                            if (item.Quality > 0)
                            {
                            }
                        }
                    }
                    else
                    {
                        if (item.Quality > 0)
                        {
                            if (!isSulfuras)
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }

                        if (!isSulfuras)
                        {
                            item.SellIn = item.SellIn - 1;
                        }

                        if (item.SellIn < 0)
                        {
                            if (item.Quality > 0)
                            {
                                if (!isSulfuras)
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
