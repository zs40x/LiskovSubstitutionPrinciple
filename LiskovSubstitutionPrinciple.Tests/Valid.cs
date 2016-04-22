using FluentAssertions;
using LiskovSubstitutionPrinciple.Valid;
using NUnit.Framework;

namespace LiskovSubstitutionPrinciple.Tests
{
    [TestFixture]
    public class Valid
    {
        [Test]
        public void Rectangle()
        {
            Shape rectangle = new Rectangle(2, 5);

            rectangle.Area.Should().Be(10);
        }

        [Test]
        public void Square()
        {
            Shape square = new Square(10);

            square.Area.Should().Be(100);
        }
    }
}
