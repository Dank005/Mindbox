using AreaShapeCalculator.Shapes;

namespace AreaShapeCalculatorTests
{
    public class CirceShapeTest
    {
        [TestCase(1, 3.14)]
        [TestCase(5, 78.53)]
        [TestCase(10, 314.15)]
        public void Simple(double radius, double area)
        {
            var circle = new Circle(radius);
            Assert.That(area, Is.EqualTo(circle.Area).Within(0.01));
        }

        [TestCase(0.0)]
        [TestCase(-5.1)]
        public void WrongRadiusException(double radius)
        {
           var exception = Assert.Throws<ArgumentException>(() => new Circle(radius));
           Assert.That(exception.Message, Is.EqualTo($"Радиус должен быть > 0, а был {radius}"));
        }
    }
}