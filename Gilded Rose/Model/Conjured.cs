using System;

namespace GildedRose.Model
{
    public class Conjured : Item
    {
        private readonly Item _item;

        public Conjured(Item item)
        {
            _item = item ?? throw new ArgumentNullException(nameof(item));
            Name = _item.Name;
            SellIn = _item.SellIn;
            Quality = _item.Quality;
        }

        #region Overrides of Item

        public override void UpdateQuality(bool updatesellin = true)
        {
            _item.UpdateQuality();
            if (_item.SellIn < -1)
                _item.UpdateQuality(false);

            SellIn = _item.SellIn;
            Quality = _item.Quality;
        }

        #endregion
    }
}
