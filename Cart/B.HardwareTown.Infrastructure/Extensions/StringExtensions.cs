using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool Contains(this string str, string substring, StringComparison comp)
        {
            if( str == null || substring == null)
            {
                throw new Exception("Strings cannot be null.");
            }
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison","comp");
            return str.IndexOf(substring, comp) >= 0;
        }
    }
}
