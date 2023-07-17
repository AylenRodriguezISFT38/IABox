//using Android.Views;
using IABox.Models.DTO;
using IABox.Services;
//using Java.Net;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IABox.Views.MenuNavigation;

public partial class FlyoutMenuPage : ContentPage
{
    #region Properties..
    ObservableCollection<FlyoutPageItem> flyoutPageItems = new ObservableCollection<FlyoutPageItem>();
    public ObservableCollection<FlyoutPageItem> FlyoutPageItems { get { return flyoutPageItems; } }
    private readonly bool isAdd = false;
    private readonly string _url = "localhost:8080";
    HttpClient _httpClient;
    public LogService _logService;
    #endregion
    public FlyoutMenuPage()
	{
		InitializeComponent();
        AddObservations(isAdd);
        _httpClient = new HttpClient();
        _logService = new LogService();
    }
    
    public void AddObservations(bool value)
    {
        if (!value)
        {
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Inicio", IconPage = "Home.png" });
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Alarmas", IconPage = "Contacts.png" });
            flyoutPageItems.Add(new FlyoutPageItem { Title = "Configuraciones", IconPage = "Settings.png" });
            value = true;
            collectionViewFlyout.ItemsSource = flyoutPageItems;
        }
    }

    private async void CloseSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(
             _url + "/SecurityController/Logout", new SessionDTO { 
                 Token = await SecureStorage.Default.GetAsync("oauth_token"),
                 Fechaexpiracion = Convert.ToDateTime(await SecureStorage.Default.GetAsync("oauth_expiration"))
             });

            if (response.IsSuccessStatusCode)
            {
                Application.Current.MainPage = new Login();
                bool secury = SecureStorage.Default.Remove("oauth_token");
            }
            else
            {
                await DisplayAlert("Error", "Se ha generado un error al cerrar sesión", "Intente nuevamente");
            }

        }
        catch (Exception ex)
        {
            _logService.Log(ex.Message);
        }
        
    }

    private  void loadWindow(object sender, EventArgs e)
    {
        var userInformation = SecureStorage.Default.GetAsync("userInformation").Result;
        UsuarioDTO user = JsonSerializer.Deserialize<UsuarioDTO>(userInformation);
        usuario.Text = user.Nombre.ToString();
        empresa.Text = user.Empresa.ToString();
    }
}