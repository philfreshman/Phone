using System;
using System.Collections.Generic;

namespace Phone
{
    public partial class Program
    {
        public class Functions : Data
        {
            // Step 1
            // Returns number from corresponding letter
            // For example 'f' returns 3

            public string DailPadNumber(char wordChar)
            {
                string result = "";

                foreach (var item in PhonePad)  // item = [3, def]
                {
                    foreach (var letter in item.Value) // letter = d,e,f
                    {
                        if (letter == wordChar)
                        {
                            result = Convert.ToString(item.Key);
                        }
                    }
                }
                return result;
            }

            // Step 2
            // Returns a number from the corresponding DailPad values
            // For example "foo" returns 366
            // Function from step 1 is included

            public string GetNumberFromWord(string word)
            {
                string key = "";

                foreach (var x in word)
                {
                    key += DailPadNumber(x);
                }

                return key;
            }



            // Step 3
            // Returns a dictionary <366,foo> from the list of words from Data.cs
            // Function from step 2 is included


            public Dictionary<string, string> GetDictionaryOfNumbers()
            {
                Dictionary<string, string> DicReturn = new Dictionary<string, string>();

                foreach (var word in Words)
                {
                    DicReturn.Add(word, GetNumberFromWord(word));
                }

                return DicReturn;
            }




        }
    }
}