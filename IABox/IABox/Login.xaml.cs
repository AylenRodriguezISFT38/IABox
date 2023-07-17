using IABox.Models.DTO;
using IABox.Services;
using IABox.Views.Enterprises;
using IABox.Views.MenuNavigation;
using RestSharp;
//using Java.Net;
//using Org.Apache.Http.Protocol;
//using Java.Nio.Channels;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
//using AppClip;

namespace IABox{

    public partial class Login : ContentPage
    {
        #region Properties...
        private JsonSerializerOptions _serializerOptions;
        private string host = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5001" : "http://localhost:5001";
        private LogService _logService;
        #endregion
        public Login()
        {
            InitializeComponent();
            _logService = new LogService();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string _url = host + "/Security/Login";

                if (!string.IsNullOrEmpty(username.Text) || !string.IsNullOrEmpty(password.Text))
                {
                   var session = SendMsg(_url).Result;
                    if (session.GetType().Name == "SessionDTO")
                    {
                        SecureStorage.Default.SetAsync("oauth_token", (session as SessionDTO).Token);
                        SecureStorage.Default.SetAsync("oauth_expiration",(session as SessionDTO).Fechaexpiracion.ToString());
                        SecureStorage.Default.SetAsync("userInformation", JsonSerializer.Serialize((session as SessionDTO).Usuario));
                        Application.Current.MainPage = new EnterpriseSelect();
                      
                    }
                    else 
                    {
                        DisplayAlert("Usuario incorrecto", "Complete el formulario", "Aceptar");
                    }
                }
                else
                {
                    DisplayAlert("Campos vacios", "Complete el formulario", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                if (DeviceInfo.Platform != DevicePlatform.Android)
                    _logService.Log(ex.Message);

                DisplayAlert("Inicio fallido", "Intente nuevamente mas tarde", "Aceptar");
            }
        
        }
        private async Task<object> SendMsg()
        {
            try
            {
                using (var _clien = new RestClient(host))
                {
                    var request = new RestRequest("/Security/Login", Method.Post);

                    _serializerOptions = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true,
                    };

                    string payload = JsonSerializer.Serialize<LoginDTO>(new LoginDTO { loginName = username.Text, pass = password.Text }, _serializerOptions);
                    StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");

                    _clien.AddDefaultHeader("Accept", "application/json");
                    _clien.AddDefaultHeader("Content-Type", "application/json");
                    _clien.AddDefaultParameter("application/json; charset=utf-8", payload, ParameterType.RequestBody);
                }
                #region httpclient..
                using (var _httpClient = new HttpClient())
                {
                    _serializerOptions = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true,
                    };

                    string payload = JsonSerializer.Serialize<LoginDTO>(new LoginDTO { loginName = username.Text, pass = password.Text}, _serializerOptions);
                    StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");
                    
                    HttpResponseMessage response = await _httpClient.PostAsync(_url, content, CancellationToken.None);

                    string _content = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return "Usuario u contraseña incorrecta";
                    }
                    else
                    {
                        return JsonSerializer.Deserialize<SessionDTO>(_content, _serializerOptions);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                return ("Error","Intentelo mas tarde","Aceptar");
                
            }
        }

    }
}