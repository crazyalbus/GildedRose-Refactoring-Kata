using csharp.Items;

namespace csharp.Utils
{
    public static class ItemExtensions
    {
        public static void Decrement_sellIn(this Item item)
        {
            item.SellIn = item.SellIn - 1;
        }

        public static void Increment_quality(this Item item)
        {
            if (item.Quality < Qualities.Max)
            {
                item.Quality = item.Quality + 1;
            }
        }

        public static void Decrement_quality(this Item item)
        {
            if (item.Quality > Qualities.Min)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}