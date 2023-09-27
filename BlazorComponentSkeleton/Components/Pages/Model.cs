namespace BlazorComponentSkeleton.Components.Pages;

public class Model
{
    private bool _value;
    
    public bool Value
    {
        get
        {
            Console.WriteLine("read Model.Value = " + _value);
            return _value;
        }
        set
        {
            Console.WriteLine("write Model.Value = " + value);
            _value = value;
        }
    }
}