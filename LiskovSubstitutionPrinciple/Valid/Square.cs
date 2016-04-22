
namespace LiskovSubstitutionPrinciple.Valid
{
    public class Square : Shape
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; }

        public override int Area => Side*Side;
    }
}
