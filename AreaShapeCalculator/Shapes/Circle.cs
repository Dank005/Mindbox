namespace AreaShapeCalculator.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public double Area { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = CalculateArea();
        }

        public double CalculateArea()
        {
            if (Radius <= 0)
                throw new ArgumentException($"Радиус должен быть > 0, а был {Radius}");

            return Math.PI * Radius * Radius;
        }
    }
}
