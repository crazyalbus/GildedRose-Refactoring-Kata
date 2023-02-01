using csharp.Utils;

namespace csharp.Items
{
    public class BackstagePassItem : IItem
    {
        private readonly Item _item;
        public int Quality => _item.Quality;
        public int SellIn => _item.SellIn;

        public BackstagePassItem(Item item)
        {
            _item = item;
        }

        public BackstagePassItem(string name_suffix, int sell_in, int quality)
        {
            _item = new Item
            {
                Name = $"{ItemNames.BackstagePasses}{name_suffix}",
                SellIn = sell_in,
                Quality = quality
            };
        }

        public void Update_daily_quality_value()
        {
            _item.Increment_quality();
            Add_extra_quality_if_concert_date_is_near();
        }

        public void Update_number_of_days_until_sell_by_date()
        {
            _item.Decrement_sellIn();
        }

        public void Update_quality_after_sell_by_date_has_passed()
        {
            _item.Quality = 0;
        }

        public override string ToString()
        {
            return _item.ToString();
        }

        private void Add_extra_quality_if_concert_date_is_near()
        {
            if (_item.SellIn <= Qualities.FirstConcertThreshold)
            {
                _item.Increment_quality();
            }

            if (_item.SellIn <= Qualities.SecondConcertThreshold)
            {
                _item.Increment_quality();
            }
        }
    }
}