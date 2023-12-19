using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GlibDesk;

public partial class AutorizationPage : UserControl
{
    public AutorizationPage()
    {
        InitializeComponent();
    }
   

    private async void Login_BTN(object? sender, RoutedEventArgs e)
    {
        HttpClient client = new HttpClient();
        if (Loginbox.Text == "" || PasswordBox.Text == "")
        {
            Oshibka.Text = "Вы ввели неверные данные!";
            return;
        }
        string parameters = "?login=" + Loginbox.Text + "&password=" + PasswordBox.Text + "&isDesktop=true";
        var request = new HttpRequestMessage(HttpMethod.Post, Program.Host + "/api/ForAllUser/login" + parameters);
        var respons = client.Send(request);
        if(respons.IsSuccessStatusCode )
        {
            Menu menu = new Menu();
            NavigationManager.NavigateTo(menu);
        }
        else if(respons.StatusCode == HttpStatusCode.BadRequest)
        {
            Oshibka.Text = "У вас недостаточно прав для входа!";
            return;
        }
        
    }
    

    private void Exit(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
    
    
}