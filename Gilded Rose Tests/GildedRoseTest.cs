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

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.AgedBrie))]
        public void AgedBrie_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Cheese { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.Elixir))]
        public void Elixir_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }


        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.Sulfuras1))]
        public void Sulfuras1_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.Sulfuras2))]
        public void Sulfuras2_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.BackstagePass1))]
        public void BackstagePass1_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            }};
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.BackstagePass2))]
        public void BackstagePass2_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            }};
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.BackstagePass3))]
        public void BackstagePass3_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new BackstagePass
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            }};
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }

        [Test]
        [TestCaseSource(typeof(GildedRoseTestCaseSource), nameof(GildedRoseTestCaseSource.Conjured))]
        public void Conjured_Tests(int day, string name, int expectedsellin, int expectedquality)
        {
            var items = new List<Item> { new Conjured(new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 })};
            var app = new GildedRose.GildedRose(items);

            for (var i = 0; i < day; i++)
            {
                app.UpdateQuality();
            }
            items[0].Name.Should().Be(name);
            items[0].SellIn.Should().Be(expectedsellin);
            items[0].Quality.Should().Be(expectedquality);
        }
    }
}