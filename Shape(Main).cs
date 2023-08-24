namessace Backend
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle();
            Square s = new Square();
            Rectangle r = new Rectangle();
            Console.Write("Input side value: ");
            r.setSide(double.Parse(Console.ReadLine()));
            Console.Write("Input width value: ");
            r.setWidth(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Area is {r.getArea()} and perimetr is {r.getPerimetr()}");
            Console.WriteLine();
            Console.Write("Input radius value: ");
            c.setSide(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Circumference is {c.getPerimetr} and area is {c.getArea}");
            Console.WriteLine();
            Console.Write("Input side value: ");
            s.setSide(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Area is: {s.getArea()} and perimetr is {s.getPerimetr()}");
        }
    }
}