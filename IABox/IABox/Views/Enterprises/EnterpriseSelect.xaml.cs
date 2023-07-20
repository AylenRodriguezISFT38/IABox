using Api.Entity;
using IABox.Services;
using IABox.Views.MenuNavigation;
using System.Net.Http.Headers;
using System.Net.Http;
//using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using IABox.Models.DTO;
using Microsoft.Maui.Controls;

namespace IABox.Views.Enterprises;

public partial class EnterpriseSelect : ContentPage, IQueryAttributable
{
    #region Properties..
    private readonly string _host = Environment.GetEnvironmentVariable("ipLocal");
    private  LogService _logService;
    private List<Empresa> empresas;
    public List<String> Images;
    public SessionDTO Data { get; private set; }
    #endregion
    public EnterpriseSelect()
	{
		InitializeComponent();
        _logService = new LogService();
    }
      
    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        try
        {
            using (var _client = new HttpClient())
            {
                string apiUrl = _host + "/Empresa";

                var response = await _client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    empresas = JsonConvert.DeserializeObject<List<Empresa>>(content);

                    empresas.ForEach((item) =>
                    {
                        item.Imagen = Environment.GetEnvironmentVariable("ipImagenes") + item.Imagen.TrimStart('.');
                    });

                    enterprises.ItemsSource = empresas;
                }
                else
                {
                    await DisplayAlert("Error", "Intentelo nuevamente mas tarde", "Aceptar");
                    Application.Current.MainPage = new Login();
                }
            }
        }
        catch (Exception ex)
        {
            if(DeviceInfo.Platform != DevicePlatform.Android)
                _logService.Log(ex.Source+"\n"+ex.Message);

            await DisplayAlert("Error","Intentelo nuevamente mas tarde","Aceptar");
        }
        
    }

    private void selectedItem(object sender, SelectedItemChangedEventArgs e)
    {
        btnEnterprise.IsEnabled = true;
        btnEnterprise.Background = Brush.Orange;
        
    }

    private async void SendEnterprise_Click(object sender, EventArgs e)
    {
        try
        {
            Dictionary<string, object> session = new Dictionary<string, object>();
            session.Add("SessionData", Data);

            await Shell.Current.GoToAsync("/FlyoutSamplePage", true, session as IDictionary<string, object>);
        }
        catch (Exception ex)
        {
             await DisplayAlert("Error", "Intentelo nuevamente mas tarde", "Aceptar");
        }
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Data = query["SessionData"] as SessionDTO; //contengo la informacion de la sesion
    }
}