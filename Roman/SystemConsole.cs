using System;

namespace Roman
{
    public class SystemConsole : IConsole
    {
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}