using System.Linq;

namespace Roman
{
    public static class RomanExtensions
    {
        public static int Value(this string readLine, char currentChar, int value, char[] rightChars)
        {
            return readLine.Select((c, index) => c == currentChar ? (readLine.Substring(index + 1).Any(rightChars.Contains) ? -value : value) : 0)
                    .Aggregate(0, (current, valueI) => current + valueI);
        }

        public static int Value(this string readLine, char currentChar, int value)
        {
            return Value(readLine,currentChar,value,new char[0]);
        }
 
    }
}