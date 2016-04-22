
namespace LiskovSubstitutionPrinciple.Violation
{
    public class Square : Rectangle
    {
        public override int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }

        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
