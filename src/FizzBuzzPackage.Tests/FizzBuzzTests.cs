using Xunit;

namespace FizzBuzzPackage.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GetResult_returns_None_for_zero_input()
        {
            var result = FizzBuzz.GetResult(0);

            const string EXPECTED = "----";

            Assert.Equal(result, EXPECTED);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(21)]
        public void GetResult_returns_Fizz_for_divided_by_3_inputs(int x)
        {
            var result = FizzBuzz.GetResult(x);

            const string EXPECTED = "Fizz";

            Assert.Equal(result, EXPECTED);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(35)]
        public void GetResult_returns_Buzz_for_divided_by_5_inputs(int x)
        {
            var result = FizzBuzz.GetResult(x);

            const string EXPECTED = "Buzz";

            Assert.Equal(result, EXPECTED);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(60)]
        [InlineData(75)]
        public void GetResult_returns_FizzBuzz_for_divided_by_3_and_5_inputs(int x)
        {
            var result = FizzBuzz.GetResult(x);

            const string EXPECTED = "FizzBuzz";

            Assert.Equal(result, EXPECTED);
        }

        [Theory]
        [InlineData(-1, "----")]
        [InlineData(-9, "Fizz")]
        [InlineData(-20, "Buzz")]
        [InlineData(-120, "FizzBuzz")]
        public void GetResult_returns_correct_result_for_negative_inputs(int x, string expected)
        {
            var result = FizzBuzz.GetResult(x);

            Assert.Equal(result, expected);
        }
    }
}
