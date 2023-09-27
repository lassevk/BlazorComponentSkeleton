using Microsoft.AspNetCore.Components.Forms;

namespace BlazorComponentSkeleton.Components.Pages;

public partial class WithEditContext
{
    private EditContext? _editContext;
    private Model? _model;

    protected override void OnInitialized()
    {
        _model ??= new Model();
        _editContext = new EditContext(_model);
    }
}