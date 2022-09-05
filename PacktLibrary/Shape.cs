namespace Packt.Shared;
public abstract class Shape
{
    // fields
    public double Height;
    public double Width;
    // properties
    public virtual double height
    {
        get
        {
            return Height;
        }
        set
        {
            Height = value;
        }
    }
    public virtual double width
    {
        get
        {
            return Width;
        }
        set
        {
            Width = value;
        }
    }
    // abstract property for overriding by its subclasses
    public abstract double Area { get; }
}



