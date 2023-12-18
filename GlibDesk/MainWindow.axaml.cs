using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GlibDesk;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void LogIn_click(object? sender, RoutedEventArgs e)
    {
        Menu menu = new Menu(); 
        Show(menu);
        this.Close();
       
        throw new System.NotImplementedException();
    }

    private void Exit(object? sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
        throw new System.NotImplementedException();
    }
}