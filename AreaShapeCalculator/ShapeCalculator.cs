using AreaShapeCalculator.Shapes;

namespace AreaShapeCalculator
{
    public static class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));
            
            return shape.CalculateArea();
        }
    }
}
