using System;

namespace GildedRose.Model
{
    public class Item
    {
        protected static int _minQuality = 0;
        protected static int _maxQuality = 50;

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void UpdateQuality(bool updatesellin = true)
        {
            if (updatesellin)
                SellIn--;
            Quality = Math.Max(Quality - (SellIn >= 0 ? 1 : 2), _minQuality);
        }
    }
}
