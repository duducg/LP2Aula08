using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtendString
{
    public static class StringExtensions
    {
        public static Random random;
        static  StringExtensions()
        {
            random = new Random();
        }
        public static string ToRandomCase(this String st)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in st)
            {
                char rc = random.NextDouble() < 0.5 ? char.ToLower(c) : char.ToUpper(c);
                sb.Append(c);
            }
            return sb.ToString();
            // foreach(char c in st)
            // {
            //     if (random.NextDouble() <= 0.5f)
            //     {
            //         sb.Append(Char.ToLower(c));
            //     }
            //     else sb.Append(Char.ToUpper(c));
            // }
            // return sb.ToString();

        }
    }
}