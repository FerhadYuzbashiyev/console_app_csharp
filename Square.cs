namespace Backend
{
    internal class Square : Shape
    {
        public override double getArea()
        {
            return side * side;
        }
        public override double getPerimetr()
        {
            return side * 4;
        }

    }
}
