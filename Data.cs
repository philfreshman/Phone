using System.Collections.Generic;

namespace Phone
{
    public static class Data
    {
        public static string phoneNumber = "3662277";


        public static string[] Words = new string[]

        { "foo", "bar", "foobar", "emo", "cap", "car", "cat", "baz"};


        public static Dictionary<char, string> PhonePad = new Dictionary<char, string>(){
            {'2',"abc" },
            {'3',"def" },
            {'4',"ghi" },
            {'5',"jkl" },
            {'6',"mno" },
            {'7',"pqrs"},
            {'8',"tuv" },
            {'9',"wxyz"}
        };
    }
}