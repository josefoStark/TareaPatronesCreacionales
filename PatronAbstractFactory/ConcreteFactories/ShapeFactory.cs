namespace PatronAbstractFactory
{
    public class ShapeFactory : IAbstractFactory
    {
        public IRectangle GetShape()
        {
            return new Rectangle();
        }

        public ISquare GetRoundedShape()
        {
            return new Square();
        }
    }
}
