using System;

namespace GildedRose.Model
{
    public class Cheese : Item
    {
        #region Overrides of Item

        public override void UpdateQuality(bool updatesellin = true)
        {
            SellIn--;
            Quality = Math.Min(Quality + (SellIn >= 0 ? 1 : 2), 50);
        }

        #endregion
    }
}
