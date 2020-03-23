using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("Number should >= 0");

            var words = str.Split(' ');
            return string.Join(' ', words.Take(numberOfWords));
        }
    }
}
