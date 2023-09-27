using System.Linq.Expressions;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorComponentSkeleton.Components;

public partial class FlipFlop
{
    [CascadingParameter]
    public EditContext? CascadedEditContext { get; set; }
    
    [Parameter]
    public bool Value { get; set; }
    
    [Parameter]
    public EventCallback<bool>? ValueChanged { get; set; }
    
    [Parameter]
    public Expression<Func<bool>>? ValueExpression { get; set; }

    private FieldIdentifier? _fieldIdentifier;
    
    protected override Task OnInitializedAsync()
    {
        if (CascadedEditContext != null && ValueExpression != null)
            _fieldIdentifier = FieldIdentifier.Create(ValueExpression);
        
        return base.OnInitializedAsync();
    }

    private async Task SetTrue()
    {
        if (ValueChanged != null)
            await ValueChanged.Value.InvokeAsync(true);

        if (CascadedEditContext != null && _fieldIdentifier != null)
            CascadedEditContext?.NotifyFieldChanged(_fieldIdentifier.Value);
    }

    private async Task SetFalse()
    {
        if (ValueChanged != null)
            await ValueChanged.Value.InvokeAsync(false);

        if (CascadedEditContext != null && _fieldIdentifier != null)
            CascadedEditContext?.NotifyFieldChanged(_fieldIdentifier.Value);
    }
}