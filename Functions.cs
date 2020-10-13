using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone
{
   
    public class Functions
    {
        // Step 1
        // Returns number from corresponding letter
        // For example 'f' returns 3

        private char DailPadNumber(char wordChar)
        {
            char result = Data.PhonePad.Where(n => n.Value.Contains(wordChar)).Select(n => n.Key).Single();
            return result;
        }

        // Step 2
        // Returns a number from the corresponding DailPad values
        // For example "foo" returns 366
        // Function from step 1 is included

        private string GetNumberFromWord(string word)
        {
            return new string(word.Select(x => DailPadNumber(x)).ToList().Aggregate("", (current, next) => current + "" + next));
        }


        // Step 3
        // Returns a dictionary <366,foo> from the list of words from Data.cs
        // Function from step 2 is included


        public Dictionary<string, string> GetDictionaryOfNumbers()
        {
            var DicReturn = new Dictionary<string, string>();

            foreach (var word in Data.Words)
            {
                DicReturn.Add(word, GetNumberFromWord(word));
            }

            return DicReturn;
        }



    }
}