using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Alpha alpha = new Alpha();
            Console.WriteLine(alpha.maxPref("zyx"));
            Console.ReadKey();
        }
    }

    public class Alpha
    {
        public int maxPref(string s)
        {
            char[] cc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == cc[i]) count++;
                else return count;
            }
            return count;
        }


    }
}
