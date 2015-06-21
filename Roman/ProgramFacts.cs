using Xunit;

namespace Roman
{
    public class ProgramFacts
    {
        [Theory]
        [InlineData("I","1")]
        [InlineData("II","2")]
        [InlineData("III","3")]
        [InlineData("V","5")]
        [InlineData("VI","6")]
        [InlineData("IV", "4")]
        [InlineData("X", "10")]
        [InlineData("XI", "11")]
        [InlineData("IX", "9")]
        [InlineData("XVI", "16")]
        [InlineData("XIV", "14")]
        [InlineData("XIX", "19")]
        [InlineData("L", "50")]
        [InlineData("XL", "40")]
        [InlineData("C", "100")]
        [InlineData("XC", "90")]
        [InlineData("XCVIII", "98")]
        public void should_print_1_given_input_I(string input, string output)
        {
            var fakeConsole = new FakeConsole {Input = input};
            Program.Console = fakeConsole;
            
            Program.Main();
            
            Assert.Equal(output,fakeConsole.Output);
        } 

    }
}