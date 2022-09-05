namespace Packt.Shared;
public class Rectangle : Shape
{
    // to initialize fields in base class Shape
    public Rectangle() { }
     
    // set initial values for height and width by accessing fields in Shape and call constructor with 'this'
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }
    // overriding Shape's Area method by its own fx
    public override double Area
    {
        get
        {
            return height * width;
        }
        
    }
}
