using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    public class BackstagePass : Item
    {
        #region Overrides of Item

        public override void UpdateQuality(bool updatesellin = true)
        {
            SellIn--;
            switch (SellIn)
            {
                case int i when i < 0:
                    Quality = 0;
                    break;
                case int i when i < 5:
                    Quality = Quality + 3;
                    break;
                case int i when i < 10:
                    Quality = Quality + 2;
                    break;
                default:
                    ++Quality;
                    break;
            }
            Quality = Math.Min(Quality, 50);
        }

        #endregion
    }
}
