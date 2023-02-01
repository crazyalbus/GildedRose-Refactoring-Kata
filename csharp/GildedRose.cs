using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class GildedRose
    {
        readonly IList<IItem> _self_managing_items;

        public GildedRose(IList<IItem> self_managing_items)
        {
            _self_managing_items = self_managing_items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _self_managing_items)
            {
                item.Update_daily_quality_value();
                item.Update_number_of_days_until_sell_by_date();
                if (item.SellIn < 0)
                {
                    item.Update_quality_after_sell_by_date_has_passed();
                }
            }
        }
    }
}
