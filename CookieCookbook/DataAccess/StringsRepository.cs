﻿namespace CookieCookbook.DataAccess;

public abstract class StringsRepository : IStringsRepository
    {
        public abstract List<string> TextToStrings(string fileContents);
        public abstract string StringsToText(List<string> strings);
        public List<string> Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                var fileContents = File.ReadAllText(filePath);
                return TextToStrings(fileContents);
            }
            return new List<string>();
        }
        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, StringsToText(strings));
        }
    }
