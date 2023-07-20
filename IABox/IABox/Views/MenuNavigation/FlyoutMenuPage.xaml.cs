//using Android.Views;
using Api.Entity;
using IABox.Models.DTO;
using IABox.Services;
using Newtonsoft.Json;
//using Java.Net;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml;

namespace IABox.Views.MenuNavigation;

public partial class FlyoutMenuPage : ContentPage
{
    #region Properties..
    ObservableCollection<FlyoutPageItem> flyoutPageItems = new ObservableCollection<FlyoutPageItem>();
    public ObservableCollection<FlyoutPageItem> FlyoutPageItems { get { return flyoutPageItems; } }
    private readonly bool isAdd = false;
    private readonly string _host = Environment.GetEnvironmentVariable("ipLocal");
    HttpClient _httpClient;
    private SessionDTO session;
    public LogService _logService;
    #endregion
    public FlyoutMenuPage()
	{
		InitializeComponent();
        _httpClient = new HttpClient();
        _logService = new LogService();
    }

    private async void CloseSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            
            string jsonBody = System.Text.Json.JsonSerializer.Serialize(
                new SessionDTO {
                    Token = SecureStorage.Default.GetAsync("auth_Token").Result, 
                    Fechaexpiracion = Convert.ToDateTime(SecureStorage.Default.GetAsync("auth_Expiration").Result) 
                });

            using (HttpClient client = new HttpClient())
            {
                string _url = _host + "/Secury/Logout";
                client.DefaultRequestHeaders.Add("Authirize", SecureStorage.Default.GetAsync("auth_Token").Result);

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(_url, content);

                if (response.IsSuccessStatusCode)
                {
                    SecureStorage.Default.Remove("oauth_token");
                    SecureStorage.Default.Remove("auth_Expiration");

                    Application.Current.MainPage = new Login();
                }
                else
                {
                    await DisplayAlert("Error", "Se ha generado un error al cerrar sesión", "Intente nuevamente");
                }
            }

        }
        catch (Exception ex)
        {
            _logService.Log(ex.Message);
        }
        
    }

    private async void loadWindow(object sender, EventArgs e)
    {
        try
        {
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Inicio", IconPage = "Home.png" });
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Alarmas", IconPage = "Contacts.png" });
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Configuraciones", IconPage = "Settings.png" });

            collectionViewFlyout.ItemsSource = flyoutPageItems;

            usuario.Text = session.Usuario.Nombre;
            empresa.Text = session.Usuario.Empresa;
            imgEmpresa.Source = Environment.GetEnvironmentVariable("ipImagenes") + session.Usuario.EmpresaImg.TrimStart('.');
        }
        catch (Exception ex)
        {
           await DisplayAlert("Error", "Se ha generado un error, intentelo mas tarde", "Intente nuevamente");
          
        }
    }
}