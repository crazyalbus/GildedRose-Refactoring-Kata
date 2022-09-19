using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        private const int MaxQuality = 50;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Item_quality_decreases_with_age(i))
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != ItemNames.Sulfuras)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < MaxQuality)
                    {
                        Increment_quality(i);

                        if (Item_is_backstage_pass(Items[i].Name))
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < MaxQuality)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < MaxQuality)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != ItemNames.Sulfuras)
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != ItemNames.AgedBrie)
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != ItemNames.Sulfuras)
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < MaxQuality)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }

        private void Increment_quality(int item_index)
        {
            Items[item_index].Quality = Items[item_index].Quality + 1;
        }

        private bool Item_is_backstage_pass(string name)
        {
            return name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private bool Item_quality_decreases_with_age(int item_index)
        {
            return (Items[item_index].Name != ItemNames.AgedBrie &&
                    Items[item_index].Name != "Backstage passes to a TAFKAL80ETC concert");
        }
    }
}
