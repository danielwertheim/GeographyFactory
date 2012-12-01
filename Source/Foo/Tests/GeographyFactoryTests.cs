using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace Foo.Tests
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    public class GeographyFactoryTests
    {
        [Test]
        public virtual void When_Coordinates_has_correct_order_and_is_closed()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.CorrectOrderAndClosed());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Coordinates_has_correct_order_and_is_not_closed()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.CorrectOrderNotClosed());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Coordinates_has_wrong_order_and_closed()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.WrongOrderAndClosed());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Coordinates_has_wrong_order_and_not_closed()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.WrongOrderNotClosed());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Coordinates_has_wrong_order_starting_south_to_north_and_many_to_west_and_back_and_is_closed()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.WrongSouthToNorthAndManyWestAndBackClosed());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Castle()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.Castle());

            Approvals.Verify(g);
        }

        [Test]
        public virtual void When_Star_drawn_from_middle_and_clockwise()
        {
            var g = GeographyFactory.CreatePolygon(CoordinatesTestFactory.StartThatDoesNotRenderWithoutFix());

            Approvals.Verify(g);
        }
    }
}