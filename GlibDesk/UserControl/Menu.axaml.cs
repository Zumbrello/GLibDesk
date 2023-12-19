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
        private ContentControl _contentControl;
        public Menu()
        {
            InitializeComponent();
            _contentControl = this.FindControl<ContentControl>("ContentControl");
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
            // Создайте новый контент (например, новый UserControl)
            var newContent = new IGRY();

            // Установите новый контент в ContentControl
            _contentControl.Content = newContent;
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