public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
}
public class circle : Drawing
{
    public double Radius { get; set; }
    public circle()
    {
        Radius = 5;
    }
    public override double Area()
    {
        return (3.14) * Math.Pow(2, Radius);
    }
}
public class Square : Drawing
{
    public double Length { get; set; }
    public Square()
    {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(2, Length);
    }
}
public class Rectangle : Drawing
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle()
    {
        Height = 5.3;
        Width = 3.6;
    }
    public override double Area()
    {
        return Height * Width;
    }
}
class program
{
    static void Main(string[] args)
    {
        Drawing circle = new circle();
        Console.WriteLine("Area:" + circle.Area());

        Drawing square = new Square();
        Console.WriteLine("Area:" + square.Area());

        Drawing Rectangle = new Rectangle();
        Console.WriteLine("Area:" + Rectangle.Area());

    }
}