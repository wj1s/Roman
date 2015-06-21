namespace Roman
{
    public class FakeConsole : IConsole
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public void WriteLine(string output)
        {
            Output = output;
        }

        public string ReadLine()
        {
            return Input;
        }
    }
}