namespace AreaShapeCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Area { get; }
        public bool IsRightAngled { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Area = CalculateArea();
            IsRightAngled = IsRightAngleExist();
        }

        public double CalculateArea()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть > 0");
            }
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Каждые 2 стороны треугольника должны быть > третьей");
            }

            var p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightAngleExist()
        {
            var squareSideA = SideA * SideA;
            var squareSideB = SideB * SideB;
            var squareSideC = SideC * SideC;

            return (squareSideA + squareSideB == squareSideC) ||
                    (squareSideB + squareSideC == squareSideA) ||
                    (squareSideA + squareSideC == squareSideB);

        }
    }
}
