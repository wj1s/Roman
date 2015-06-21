using System.Linq;

namespace Roman
{
    class Program
    {
        public static IConsole Console = new SystemConsole();

        public static void Main()
        {
            var readLine = Console.ReadLine();

            var valueI = readLine.Value('I', 1, new[] {'V', 'X'});
            var valueV = readLine.Value('V', 5);
            var valueX = readLine.Value('X', 10, new[] { 'L','C' });
            var valueL = readLine.Value('L', 50);
            var valueC = readLine.Value('C', 100);

            Console.WriteLine((valueI + valueV + valueX + valueL + valueC).ToString());
        }
    }
}
