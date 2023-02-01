using csharp.Utils;

namespace csharp.Items
{
    public class LegendaryItem : IItem
    {
        private readonly Item _item;
        public int Quality => _item.Quality;
        public int SellIn => _item.SellIn;

        public LegendaryItem(Item item)
        {
            _item = item;
        }

        public LegendaryItem(int sell_in, int quality)
        {
            _item = new Item
            {
                Name = ItemNames.Sulfuras,
                SellIn = sell_in,
                Quality = quality
            };
        }

        public void Update_daily_quality_value()
        {
        }

        public void Update_number_of_days_until_sell_by_date()
        {
        }

        public void Update_quality_after_sell_by_date_has_passed()
        {
        }

        public override string ToString()
        {
            return _item.ToString();
        }
    }
}