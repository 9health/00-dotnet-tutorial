namespace AbstractClassesVsInterface;

public interface INoImplementation // C# 1.0 and later
{
    void Alpha(); // must be implemented by derived type
}
public interface ISomeImplementation // C# 8.0 and later
{
    void Alpha(); // must be implemented by derived type
    void Beta()
    {
        // default implementation; can be overridden
    }
}
public abstract class PartiallyImplemented // C# 1.0 and later
{
    public abstract void Gamma(); // must be implemented by derived type
    public virtual void Delta() // can be overridden
    {
        // implementation
    }
}
public class FullyImplemented : PartiallyImplemented, ISomeImplementation
{
    public void Alpha()
    {
        // implementation
    }
    public override void Gamma()
    {
        // implementation
    }
}
