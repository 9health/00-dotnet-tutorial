
[AttributeUsage(AttributeTargets.All)]
public class NHFoodVerEAttribute : Attribute {

    // Fields
    public string Author   { get; }
    public string Version  { get; }
    public bool   Reviewed { get; set; }

    public NHFoodVerEAttribute(string author, string version, bool reviewed) {
        Author   = author   ;
        Version  = version  ;
        Reviewed = reviewed ;
    }

    // Methods
}

