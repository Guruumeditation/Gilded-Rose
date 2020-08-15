using System;
using System.Data.SqlTypes;

namespace GildedRose.Model
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void UpdateQuality(bool updatesellin = true)
        {
            if (updatesellin)
                SellIn--;
            Quality = Math.Max(Quality - (SellIn >= 0 ? 1 : 2),0);
        }
    }
}
