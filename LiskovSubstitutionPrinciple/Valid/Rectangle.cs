namespace LiskovSubstitutionPrinciple.Valid
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; }
        public int Width { get; }

        public override int Area => Width * Height;
    }
}
