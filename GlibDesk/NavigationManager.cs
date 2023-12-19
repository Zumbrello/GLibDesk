using Avalonia.Controls;

namespace GlibDesk;

public class NavigationManager
{
    private static ContentControl _contentControl;

    public static void Initialize (ContentControl contentControl)
    {
        _contentControl = contentControl;
    }

    public static void NavigateTo(UserControl page)
    {
        _contentControl.Content = page;
    }
}