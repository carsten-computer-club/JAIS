using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Styling;

namespace AppCore.Controls;

public class TapScrollableButton : Button, IStyleable
{
    Type IStyleable.StyleKey => typeof(Button);

    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        base.OnPointerPressed(e);

        //Allow ScrollViewer handle touch scroll 
        e.Handled = false;
    }
}