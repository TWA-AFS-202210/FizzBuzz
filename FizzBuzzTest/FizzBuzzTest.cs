
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    using FizzBuzz;
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_when_call_countoff_given_normal_number()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(1);

            //then
            Assert.Equal("1", res);
        }

        [Fact]
        public void Should_return_fizz_when_call_countoff_given_multiple_of_three()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(3);

            //then
            Assert.Equal("Fizz", res);
        }
    }
}