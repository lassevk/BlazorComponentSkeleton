namespace BlazorComponentSkeleton.Components.Pages;

public partial class Unbound
{
    private FlipFlop? _ref;

    private void SetTrue()
    {
        _ref!.Value = true;
    }

    private void SetFalse()
    {
        _ref!.Value = false;
    }
}