using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Controls.ApplicationLifetimes;

namespace GlibDesk
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            // Дополнительные инициализации могут быть добавлены здесь.
        }

        private void Logoff(object? sender, RoutedEventArgs e)
        {
            AutorizationPage autorizationpage = new AutorizationPage();
            NavigationManager.NavigateTo(autorizationpage);
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
            throw new System.NotImplementedException();
        }
    }
}