using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GildedRose.Model;

namespace Gilded_Rose_Tests.Sources
{
    public static class GildedRoseTestCaseSource
    {
        private static Dictionary<string, IEnumerable<Item>> _expectedresults;
        static GildedRoseTestCaseSource()
        {
            var json = File.ReadAllText("Sources/ApprovedResults.json");
            _expectedresults = JsonSerializer.Deserialize<Dictionary<string, IEnumerable<Item>>>(json);
        }

        public static IEnumerable<object[]> DexterityVest()
        {
            return GetExpectedResults("+5 Dexterity Vest");
        }

        private static IEnumerable<object[]> GetExpectedResults(string itemname)
        {
            var results = _expectedresults.SelectMany(d => d.Value).Where(d => d.Name == itemname).ToList();

            for (int i = 0; i < results.Count; i++)
            {
                yield return
                    new object[] {i, results[i].Name, results[i].SellIn, results[i].Quality };
            }
        }
    }
}
