namespace CookieCookbook.DataAccess;

public class StringsTextualRepository : StringsRepository
    {
        private static readonly string Separator = Environment.NewLine;

        public override string StringsToText(List<string> strings)
        {
            return string.Join(Separator, strings);
        }

        public override List<string> TextToStrings(string fileContents)
        {
            return fileContents.Split(Separator).ToList();
        }
    }
