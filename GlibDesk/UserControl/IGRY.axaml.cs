using System.Collections.Generic;
using System.Net.Http;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GameLib.Models;

namespace GlibDesk;

public partial class IGRY : UserControl
{
    public IGRY()
    {
        HttpClient client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, Program.Host + "/api/ForAllUser/getgame");
        /*request.Headers.Add("Authorization", "Bearer " + MainWindowVM.config.AppSettings.Settings["RefreshToken"].Value);*/
        var respons = client.Send(request);
        InitializeComponent();
        /*List<Game> data = respons.*/
        _igryListBox = this.FindControl<ListBox>("IgryListBox");
        /*igryListBox.ItemsSource = data;*/
    }
    private ListBox _igryListBox;
    
}