using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace GlibDesk;

public partial class Menu : Window
{
    public Menu()
    {
        InitializeComponent();
    }

    private void Logoff(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Prosmotr_Igr(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Prosmotr_polzakov(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        Show(mainWindow);
        this.Close();
        
        throw new System.NotImplementedException();
    }
}