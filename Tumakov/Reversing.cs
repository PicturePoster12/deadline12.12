using System;
namespace Tumakov
{
    public class Reversing
    {
        public string ReversingString(string str)
        {
            string reversedString = new string(str.Reverse().ToArray());
            return reversedString;
        }
    }
}
