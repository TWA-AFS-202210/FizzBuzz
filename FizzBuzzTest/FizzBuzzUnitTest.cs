using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void Should_return_number_what_given()
        {
            //given
            FizzBuzz.FizzBuzz class1 = new FizzBuzz.FizzBuzz();
            int i = 1;
            //when
            string result = class1.GetString(i);
            //then
            Assert.Equal(1.ToString(), result);
        }
    }
}