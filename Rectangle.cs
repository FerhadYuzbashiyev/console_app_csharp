namespace Backend
{
    internal class Rectangle : Shape
    {
        public override double getArea()
        {
            return width * side;
        }
        public override double getPerimetr()
        {
            return (width + side) * 2;
        }
    }
}
