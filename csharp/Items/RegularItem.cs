using csharp.Utils;

namespace csharp.Items
{
    internal class RegularItem : IItem
    {
        private readonly Item _item;
        public int Quality => _item.Quality;
        public int SellIn => _item.SellIn;

        public RegularItem(Item item)
        {
            _item = item;
        }

        public RegularItem(string name, int sell_in, int quality)
        {
            _item = new Item
            {
                Name = name,
                SellIn = sell_in,
                Quality = quality
            };
        }

        public void Update_daily_quality_value()
        {
            _item.Decrement_quality();
        }

        public void Update_number_of_days_until_sell_by_date()
        {
            _item.Decrement_sellIn();
        }

        public void Update_quality_after_sell_by_date_has_passed()
        {
            _item.Decrement_quality();
        }

        public override string ToString()
        {
            return _item.ToString();
        }
    }
}