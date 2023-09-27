using Microsoft.AspNetCore.Components.Forms;

namespace BlazorComponentSkeleton.Components.Pages;

public partial class WithEditContext
{
    private readonly Model _model = new();
    private EditContext? _editContext;

    protected override void OnInitialized()
    {
        _editContext = new EditContext(_model);
    }

    private void SetTrue()
    {
        _model.Value = true;
    }

    private void SetFalse()
    {
        _model.Value = false;
    }
}