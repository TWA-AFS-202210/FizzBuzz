using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_normal_number_When_countOff_Given_normal_number()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int normalNumber = 1;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(normalNumber);
            //then
            Assert.Equal("1", countOffReturnResult);
        }
    }
}