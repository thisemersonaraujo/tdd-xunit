using System;
using MyProject;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example1
    {
        private readonly ITestOutputHelper _output;
        public Example1(ITestOutputHelper output)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }


        [Fact]
        public void UsuarioEhMaiorDeIdade()
        {
            // Arrange
            var user = new User("Emerson", 28);
            var expected = true;

            // Act
            bool result = user.MaiorDeIdade();
            _output.WriteLine($"result: {result}");

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UsuarioEhMenorDeIdade()
        {
            // Arrange
            var user = new User("Igor", 17);
            var expected = false;

            // Act
            bool result = user.MaiorDeIdade();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        [Trait("Category", "Sums")]
        public void SumFivePlusTwoIsEqualSeven()
        {
            // Arrange
            var first = 5;
            var second = 2;
            var expected = 7;

            // Act
            var result = first + second;

            // Assert
            _output.WriteLine($"SumFivePlusTwoIsEqualSeven: {first} + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Sums Theories")]
        [Trait("Category", "Sums")]
        [InlineData(1, 1, 2)]
        [InlineData(14, 78, 92)]
        [InlineData(30, 45, 75)]
        [InlineData(7, 12, 19)]
        public void SumFirstPlusSecondIsEqualThird(int first, int second, int expected)
        {
            // Arrange
            // Act
            var result = first + second;

            // Assert
            _output.WriteLine($"SumFirstPlusSecondIsEqualThird: {first} + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "DivisionByZero not implemented", Skip = "Not Implemented")]
        public void DivisionByZero()
        {
            // TODO: Needs to be implemented
            // HACK: Needs to be implemented
            // UNDONE: Needs to be implemented
        }
    }
}