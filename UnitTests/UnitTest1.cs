using MainProject;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(3, 2, 5)]
        public void AddTest(int num1, int num2, int expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        public void SubtractTest(double num1, double num2, double expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Seth", "Hello, Seth!")]
        [InlineData("John", "Hello, John!")]
        [InlineData("", "Hello!")]
        [InlineData(null, "Hello!")]
        public void GreetTest(string name, string expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Greeting(name);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}