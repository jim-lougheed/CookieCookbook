using System.Text.Json;

namespace CookieCookbook.DataAccess;

public class StringsJSONRepository : StringsRepository
    {
        public override List<string> TextToStrings(string fileContents)
        {
            return JsonSerializer.Deserialize<List<string>>(fileContents);
        }

        public override string StringsToText(List<string> strings)
        {
            return JsonSerializer.Serialize(strings);
        }
    }
