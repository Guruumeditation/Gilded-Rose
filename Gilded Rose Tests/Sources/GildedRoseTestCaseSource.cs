using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GildedRose.Model;

namespace Gilded_Rose_Tests.Sources
{
    public static class GildedRoseTestCaseSource
    {
        private static readonly List<TestItem> _expectedresults;
        private static int _numberofdays = 31;
        static GildedRoseTestCaseSource()
        {
            var json = File.ReadAllText("Sources/ApprovedResults.json");
            _expectedresults = JsonSerializer.Deserialize<List<TestItem>>(json);
        }

        public static IEnumerable<object[]> DexterityVest()
        {
            return GetExpectedResults("+5 Dexterity Vest");
        }

        public static IEnumerable<object[]> AgedBrie()
        {
            return GetExpectedResults("Aged Brie");
        }

        public static IEnumerable<object[]> Elixir()
        {
            return GetExpectedResults("Elixir of the Mongoose");
        }

        public static IEnumerable<object[]> Sulfuras1()
        {
            return GetExpectedResults("Sulfuras, Hand of Ragnaros");
        }

        public static IEnumerable<object[]> Sulfuras2()
        {
            return GetExpectedResults("Sulfuras, Hand of Ragnaros",1);
        }

        public static IEnumerable<object[]> BackstagePass1()
        {
            return GetExpectedResults("Backstage passes to a TAFKAL80ETC concert");
        }

        public static IEnumerable<object[]> BackstagePass2()
        {
            return GetExpectedResults("Backstage passes to a TAFKAL80ETC concert",1);
        }

        public static IEnumerable<object[]> BackstagePass3()
        {
            return GetExpectedResults("Backstage passes to a TAFKAL80ETC concert",2);
        }

        public static IEnumerable<object[]> Conjured()
        {
            return GetExpectedResults("Conjured Mana Cake");
        }

        private static IEnumerable<object[]> GetExpectedResults(string itemname, int index = 0)
        {
            var results = _expectedresults.Where(d => d.Name == itemname).Skip(31 * index).Take(31).ToList();

            foreach (var result in results)
            {
                yield return
                    new object[] { result.Day, result.Name, result.SellIn, result.Quality };
            }
        }
    }
}
