using System;
using System.Collections.Generic;

namespace Phone
{
    public partial class Program
    {
        public class Comparison : Functions
        {

            // Counts how many times (starting from which position)
            // you can compare one number to another

            public int HowManyTimes(string input) // supply word
            {
                int phoneLength = phoneNumber.Length; // 3662277 length 7
                int wordLength = input.Length; // foo length 3
                int counter = 0;

                for (int i = phoneLength; i >= wordLength; i--)
                {
                    counter++;
                }
                return counter; // 5
            }



            public void Operation(string key, string value) //| foo | 366 |
            {
                string number = value; // 366

                int repeat = HowManyTimes(number); // Number of repetations = 5

                int compareGoal = 0; // goal is to get for example 3 (foo) succesful comparisons in a row

                bool numberIncluded = false;


                for (int i = 0; i < repeat; i++) // number of repetitions
                {
                    for (int y = 0; y < number.Length; y++) // comparison of each single number
                    {
                        if (number[y] == phoneNumber[y + i]) // + i to swap the starting index
                        {
                            compareGoal++;
                        }
                        else
                        {
                            compareGoal = 0; // resets when one of the following numbers does not match
                        }

                        if (compareGoal == number.Length)
                        {
                            Console.WriteLine($"{phoneNumber} contains {key} ({value})");
                            numberIncluded = true;
                            break;
                        }

                    }


                    if (i == repeat - 1 && numberIncluded == false)
                    {
                        Console.WriteLine($"{phoneNumber} does not contain {key} ({value})");
                    }

                }

            }




            public void Start()
            {
                Dictionary<string, string> dictionary = GetDictionaryOfNumbers();

                foreach (var item in dictionary)
                {
                    Operation(item.Key, item.Value);
                }

            }

        }
    }
}