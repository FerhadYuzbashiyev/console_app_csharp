namespace Backend
{
    internal class Circle : Shape
    {
        public override double getArea()
        {
            return (Math.PI * Math.Pow(side,2));
        }
        public override double getPerimetr()
        {
            return (2 * Math.PI * side);
        }
    }
}
