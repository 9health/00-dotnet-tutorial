namespace Packt.Shared;

public class Circle : Square
{
    //to initialize fields in base class Square
    public Circle() { }

    //to set initial values for radius by accessing fields in Square and call constructor with 'base'(~this) radius = 1/2 circumference
    public Circle(double radius) : base(width: radius * 2) { }

    public double Radius
    {
        get { return height / 2; }
        set
        {
            Height = value * 2;
        }
    }
    public override double Area
    {
        get
        {
            double radius = height / 2;
            return Math.PI * radius * radius;
        }
        
    }
}