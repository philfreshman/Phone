using System.Collections.Generic;

namespace Phone
{
    public class Data
    {
        public const string phoneNumber = "3662277";


        public string[] Words = new string[]

        { "foo", "bar", "foobar", "emo", "cap", "car", "cat", "baz"};


        public Dictionary<int, string> PhonePad = new Dictionary<int, string>(){
            {2,"abc" },
            {3,"def" },
            {4,"ghi" },
            {5,"jkl" },
            {6,"mno" },
            {7,"pqrs"},
            {8,"tuv" },
            {9,"wxyz"}
        };
    }
}