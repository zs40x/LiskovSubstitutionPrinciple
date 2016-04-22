
namespace LiskovSubstitutionPrinciple.Violation
{
    public class Rectangle
    {
        protected int width;
        protected int height;

        public virtual int Height
        {
            get { return height; }
            set { height = value; }
        }

        public virtual int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Area
        {
            get
            {
                return width * height;
            }
        }
    }
}
