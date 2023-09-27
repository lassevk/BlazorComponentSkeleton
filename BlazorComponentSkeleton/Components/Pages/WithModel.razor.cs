namespace BlazorComponentSkeleton.Components.Pages;

public partial class WithModel
{
    private readonly Model _model = new Model();

    private void SetTrue()
    {
        _model.Value = true;
    }

    private void SetFalse()
    {
        _model.Value = false;
    }
}