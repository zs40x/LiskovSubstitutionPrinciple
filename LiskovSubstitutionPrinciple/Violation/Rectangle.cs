
namespace LiskovSubstitutionPrinciple.Violation
{
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public virtual int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public virtual int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Area => _width * _height;
    }
}
