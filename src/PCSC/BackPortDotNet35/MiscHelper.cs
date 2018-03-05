using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCSC.BackPortDotNet35
{
    public static class MiscHelper
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            if (value == null) return true;

            return value.All(t => t.IsWhiteSpaceLatin1());
        }

        private static bool IsWhiteSpaceLatin1(this char c)
        {

            // There are characters which belong to UnicodeCategory.Control but are considered as white spaces.
            // We use code point comparisons for these characters here as a temporary fix.

            // U+0009 = <control> HORIZONTAL TAB
            // U+000a = <control> LINE FEED
            // U+000b = <control> VERTICAL TAB
            // U+000c = <contorl> FORM FEED
            // U+000d = <control> CARRIAGE RETURN
            // U+0085 = <control> NEXT LINE
            // U+00a0 = NO-BREAK SPACE
            if ((c == ' ') || (c >= '\x0009' && c <= '\x000d') || c == '\x00a0' || c == '\x0085')
            {
                return (true);
            }
            return (false);
        }
    }
}
