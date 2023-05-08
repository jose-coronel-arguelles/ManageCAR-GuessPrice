using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;

namespace KForce.Web.Helpers;

public class InputFormattedNumber : InputNumber<Decimal>
{
    [Parameter] public string FormatString { get; set; }

    private string formattedNumber => getFormattedValue(this.Value);

    private string stringValue
    {
        get => formattedNumber;
        set => CurrentValueAsString = getFormattedValue(decimal.Parse(value));
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "input");
        builder.AddMultipleAttributes(2, AdditionalAttributes);
        builder.AddAttribute(3, "type", "number");
        builder.AddAttribute(4, "class", CssClass);
        builder.AddAttribute(5, "value", formattedNumber);
        builder.AddAttribute(6, "onchange", EventCallback.Factory.CreateBinder<string?>(this, __value => stringValue = __value, stringValue));
        builder.CloseElement();
    }

    private string getFormattedValue(decimal value)
    {
        if (!String.IsNullOrWhiteSpace(FormatString))
        {
            try
            {
                return value.ToString(this.FormatString);
            }
            catch { }
        }
        return value.ToString();
    }

}