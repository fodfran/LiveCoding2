using System;

namespace LongRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(longRepeat("aaa"));
            Console.WriteLine(longRepeat("a"));
            Console.WriteLine(longRepeat("bdsagbgagggaaatttyyyyau"));
            Console.WriteLine(longRepeat("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(longRepeat(""));
        }

        static int longRepeat(string s)
        {
            int finalCount = 0;

            if (s.Length == 0)
                return finalCount;
            

            char now = s[0];
            finalCount = 1;
            int count = 1;

            foreach (char c in s.Substring(1))
            {
                if (c == now)
                {
                    count++;
                    now = c;
                    if (count > finalCount)
                        finalCount = count;
                    
                }
                else
                {
                    count = 1;
                    now = c;
                }
            }

            return finalCount;

        }
            
    }
}
