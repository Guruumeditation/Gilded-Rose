using System;

namespace GildedRose.Model
{
    public class Conjured : Item
    {
        private readonly Item _item;

        public Conjured(Item item)
        {
            _item = item ?? throw new ArgumentNullException(nameof(item));
        }

        #region Overrides of Item

        public override void UpdateQuality(bool updatesellin = true)
        {
            _item.UpdateQuality();
            _item.UpdateQuality(false);

            SellIn = _item.SellIn;
            Quality = _item.Quality;
        }

        #endregion
    }
}
