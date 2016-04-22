using NUnit.Framework;
using FluentAssertions;
using LiskovSubstitutionPrinciple.Violation;

namespace LiskovSubstitutionPrinciple.Tests
{
    [TestFixture]
    public class Violation
    {
        [Test]
        public void RectangleIsOkay()
        {
            Rectangle rect = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            rect.Area.Should().Be(50);
        }

        [Test]
        public void SquareDoesntWorkAsExpected()
        {
            Rectangle rect = new Square
            {
                Width = 5,
                Height = 10
            };

            /*
             * Te following Assertions failes, because Square modifies 
             * the behaviour of Rectangle. Changing width or height 
             * always changes both attributes to be a valid Square.
             * 
             * => Violation of the Liskov Substitution Principle
             */
            rect.Area.Should().Be(50);
        }
    }
}
