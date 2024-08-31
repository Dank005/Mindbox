using AreaShapeCalculator.Shapes;

namespace AreaShapeCalculatorTests
{
    public class TriangleShapeTest
    {
        [TestCase(6, 8, 10, 24)]
        [TestCase(9, 12, 15, 54)]
        [TestCase(2, 4, 5, 3.79)]
        public void Simple(double a, double b, double c, double area)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(area, Is.EqualTo(triangle.Area).Within(0.01));
        }

        [TestCase(1, 1, -1)]
        [TestCase(0, 2, 1)]
        public void WrongSideException(double a, double b, double c)
        {
           var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
           Assert.That(exception.Message, Is.EqualTo("Все стороны треугольника должны быть > 0"));
        }

        [TestCase(6, 8, 15)]
        [TestCase(2, 3, 7)]
        public void SumTwoSidesLessOtherException(double a, double b, double c)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.That(exception.Message, Is.EqualTo("Каждые 2 стороны треугольника должны быть > третьей"));
        }

        [TestCase(2, 4, 5, false)]
        [TestCase(3, 4, 5, true)]
        public void CheckRightAngle(double a, double b, double c, bool isRightAngled)
        {
            var triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRightAngled, Is.EqualTo(isRightAngled));
        }
    }
}