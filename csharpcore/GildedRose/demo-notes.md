## Principles:

- test coverage,
- small steps,
- always run the tests,
- commit moves separate from code changes,
- use a trunk-based approach,
- choose refactorings based on performance evidence rather than instinct or preference
- proghressive refactor - start from the simplest change

## Steps to take

Follow numbered steps below.

## a. Get set up

Do this as part of the demo so people see you get tests working.
In Rider (on Mac), open csharpcore folder
In GildedRoseTest.cs, fix fixme
Run all tests, and approve the output in the diff tool
If diff tool doesn't open, run this in terminal:
- (Make sure you're in right subfolder: `cd GildedRoseTests`)
- Run `mv ApprovalTest.ThirtyDays.received.txt ApprovalTest.ThirtyDays.approved.txt`

## 1. Magic strings:

Automated refactoring: select strings one at a time.
In Rider, Cmd + Shift + R -> introduce field -> introduce constant

// Only replace one magic string at a time

## 2. Extract methods:

Item_quality_decreases_with_age(int item_index)
Item_is_backstage_pass(item_index)
Item_is_not_aged_brie(item_index)
Item_is_not_backstage_pass(item_index)
Item_is_not_sulfuras(item_index)

Increment_quality(item_index)
Decrement_quality(item_index)
Decrement_SellIn(item_index)

## 3. Nasty numbers

        private const int FirstConcertQualityThreshold = 10;
        private const int SecondConcertQualityThreshold = 5;
        private const int MaxQuality = 50;

## 4. Unnecessary if:

if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
{
Items[i].Quality = Items[i].Quality - 1;
}

## 5. Move if statement to Increment_quality method

if (_items[item_index].Quality < MaxQuality)
{
_items[item_index].Quality = _items[item_index].Quality + 1;
}

## 6. Move if statement to Decrement_quality method

if (_items[item_index].Quality > 0 && Item_is_not_legendary(item_index))
{
_items[item_index].Quality = _items[item_index].Quality - 1;
}

## 7. Extract methods

Add_extra_quality_if_concert_date_is_near(item_index)
Adjust_quality_if_sell_by_date_has_passed(item_index)
Adjust_number_of_days_to_sell_by_date(item_index)