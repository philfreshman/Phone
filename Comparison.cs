using System;
using System.Collections.Generic;

namespace Phone
{
    public class Comparison 
    {

        // Counts how many times (starting from which position)
        // you can compare one number to another

        public int HowManyTimes(string word)
        {
            int compareTimes = Data.phoneNumber.Length - word.Length + 1;
               
            return compareTimes; 
        }


        public void Operation(string key, string value) //| foo | 366 |
        {
            int repeat = HowManyTimes(value);

            int compareGoal = 0; // for "foo" the goal is to get for example 3 succesful comparisons in a row

            bool numberIncluded = false;


            for (int i = 0; i < repeat; i++) // number of repetitions
            {
                for (int y = 0; y < value.Length; y++) // comparison of each single number
                {
                    if (value[y] == Data.phoneNumber[y + i]) // + i to swap the starting index
                    {
                        compareGoal++;
                    }
                    else
                    {
                        compareGoal = 0; // resets when one of the following numbers does not match
                    }

                    if (compareGoal == value.Length)
                    {
                        Console.WriteLine($"{Data.phoneNumber} contains {key} ({value})");
                        numberIncluded = true;
                        break;
                    }
                }

                if (i == repeat - 1 && numberIncluded == false)
                {
                    Console.WriteLine($"{Data.phoneNumber} does not contain {key} ({value})");
                }
            }
        }


        public void Start()
        {
            var function = new Functions();
            var dictionary = function.GetDictionaryOfNumbers();

            foreach (var item in dictionary)
            {
                Operation(item.Key, item.Value);
            }
        }
    }
}