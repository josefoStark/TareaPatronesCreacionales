namespace PatronAbstractFactory
{
    public interface IAbstractFactory
    {
        IRectangle GetShape();

        ISquare GetRoundedShape();
    }

}
