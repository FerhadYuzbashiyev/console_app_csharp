namespace Backend
{
    internal abstract class Shape
    {
        protected double side;
        protected double width;
        protected double height;

        public void setSide(double side)
        {
            this.side = side;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getSide()
        {
            return side;
        }
        public double getWidth()
        {
            return width;
        }
        public double getHeigth()
        {
            return height;
        }
        public abstract double getArea();
        public abstract double getPerimetr();
        
    }
}
