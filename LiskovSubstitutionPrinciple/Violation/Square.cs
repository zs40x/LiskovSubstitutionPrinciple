
namespace LiskovSubstitutionPrinciple.Violation
{
    public class Square : Rectangle
    {
        public override int Height
        {
            get
            {
                return height;
            }
            set
            {
                width = value;
                height = value;
            }
        }

        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                height = value;
            }
        }
    }
}
