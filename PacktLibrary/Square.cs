
namespace Packt.Shared;

public class Square : Rectangle
{
    //to initialize fields in base class Rectangle
    public Square() { }

    //to set initial values for height and width by accessing fields in Rectangle and call constructor with 'base'
    public Square(double width) : base(height: width, width: width) { }

    public override double height
    {
        set
        {
            height = value;
        }
    }
    public override double width
    {
        set
        {
            width = value;
        }
    }
}
