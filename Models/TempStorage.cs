using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieSite.Models
{
    public class TempStorage
    {
        private static List<Suggestion> SuggList = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => SuggList;

        public static void addSuggestion(Suggestion newSuggestion)
        {
            SuggList.Add(newSuggestion);
        }
    }
}
