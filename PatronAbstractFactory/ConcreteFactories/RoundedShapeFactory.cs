namespace PatronAbstractFactory
{
    public class RoundedShapeFactory : IAbstractFactory
    {
        public IRectangle GetShape()
        {
            return new RoundedRectangle();
        }

        public ISquare GetRoundedShape()
        {
           return  new RoundedSquare();
        }
    }
}
