using csharp.Utils;

namespace csharp.Items
{
    internal class ConjuredItem : IItem
    {
        private readonly Item _item;
        public int Quality => _item.Quality;
        public int SellIn => _item.SellIn;

        public ConjuredItem(Item item)
        {
            _item = item;
        }

        public ConjuredItem(int sell_in, int quality)
        {
            _item = new Item
            {
                Name = ItemNames.Conjured,
                SellIn = sell_in,
                Quality = quality
            };
        }

        public void Update_daily_quality_value()
        {
            Decrement_quality_twice();
        }

        public void Update_number_of_days_until_sell_by_date()
        {
            _item.Decrement_sellIn();
        }

        public void Update_quality_after_sell_by_date_has_passed()
        {
            Decrement_quality_twice();
        }

        public override string ToString()
        {
            return _item.ToString();
        }

        private void Decrement_quality_twice()
        {
            _item.Decrement_quality();
            _item.Decrement_quality();
        }
    }
}