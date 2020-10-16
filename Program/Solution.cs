using System;
using System.Linq;
namespace Program
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var len = (int)Math.Log10(x);

            while (x != 0)
            {
                var low = x % 10;
                var high = x / (int)Math.Pow(10, len);

                if (low != high) return false;
                x = x % (int)Math.Pow(10, len) / 10;

                len -= 2;
            }
            return true;
        }

        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int list = x % 10;
        int NewRev = rev * 10 + list;
                if ((NewRev - list) / 10 != rev)
                {
                    break;
                }
                rev = NewRev;

                x = x / 10;
            }
            return rev;
        }

        public static bool IsFilter(string y)
        {
            if (y != string.Concat(y.Where(x => char.IsLetterOrDigit(x))))
                return true;
            else
            {
                var newText = string.Concat(y.ToLower()
                    .Where((a) => char.IsDigit(a) || (a >= 'a' & a <= 'z'))
                    .Where(x => !char.IsDigit(x))
                    .ToArray());
                var export = IsPalindrome_Text(newText);
                return export;
            }
        }

        private static bool IsPalindrome_Text(string x)
        {
            if (x.Length <= 1)
                return true;
            else
            {
                if (x[0] != x[x.Length - 1])
                    return false;
                else
                    return IsPalindrome_Text(x.Substring(1, x.Length - 2));
            }
        }
    }
}
