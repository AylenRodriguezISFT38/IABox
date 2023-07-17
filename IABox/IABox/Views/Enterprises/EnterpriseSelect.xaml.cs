using Api.Entity;
using IABox.Services;
using IABox.Views.MenuNavigation;
//using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IABox.Views.Enterprises;

public partial class EnterpriseSelect : ContentPage
{
    #region Properties..
    private readonly string _host = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5001" : "http://127.0.0.1:5001";
    private LogService _logService;
    private JsonSerializerOptions _serializerOptions;
    private List<Empresa> _empresaList;
    private string _url;
    private Empresa empresa;
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
                _url = _host + "/Empresa/GetEmpresa";

                _client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", SecureStorage.Default.GetAsync("oauth_token").Result);
                _client.DefaultRequestHeaders.Add("content-type", "application/json");
                _client.DefaultRequestHeaders.TryAddWithoutValidation("meta-charset", "utf-8");

                _serializerOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };

                HttpResponseMessage response = await _client.GetAsync(_url);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    _empresaList = JsonSerializer.Deserialize<Empresa>(content,_serializerOptions);
                    lstEnterprises.ItemsSource = _empresaList;

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

    private async void selectEnterprise_Click(object sender, SelectedItemChangedEventArgs e)
    {
        try
        {
            try
            {
                using (var _client = new HttpClient())
                {
                    _url = _host + "/Empresa/GetHeartbeat";
                    StringContent content = new StringContent(lstEnterprises.SelectedItem as string, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _client.PostAsync(_url, content, CancellationToken.None);

                    if (response.IsSuccessStatusCode)
                    {
                        string _content = await response.Content.ReadAsStringAsync();
                        //empresa = JsonSerializer.Deserialize<Empresa>(_content, _serializerOptions);
                        empresa = JsonConvert.DeserializeObject(_content) as Empresa;
                    }
                }
            }
            catch (Exception ex)
            {
                _logService.Log(ex.Source + "\n" + ex.Message);
                await DisplayAlert("Error", "Intentelo nuevamente mas tarde", "Aceptar");
            }
        }
        catch (Exception ex)
        {
            _logService.Log(ex.Source + "\n" + ex.Message);
            await DisplayAlert("Error", "Intentelo nuevamente mas tarde", "Aceptar");
        }
    }

    private void EnterpriseSelected_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new FlyoutSamplePage(empresa);
    }
}