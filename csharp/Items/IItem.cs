namespace csharp.Items
{
    public interface IItem
    {
        int Quality { get; }
        int SellIn { get; }
        void Update_daily_quality_value();
        void Update_number_of_days_until_sell_by_date();
        void Update_quality_after_sell_by_date_has_passed();
    };
}