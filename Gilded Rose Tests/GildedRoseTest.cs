using System.Collections.Generic;
using FluentAssertions;
using Gilded_Rose_Tests.Sources;
using GildedRose.Model;
using NUnit.Framework;

namespace Gilded_Rose_Tests
{
    public class GildedRoseTest
    {
        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.DexterityVest))]

        public void DexterityVest_Tests(int day ,string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
            var app = new GildedRose.GildedRose(items);

            for (var i = 0 ; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }
    }
}