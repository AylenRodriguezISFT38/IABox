using Api.Entity;
//using CoreML;
using IABox.Models.DTO;
using IABox.Services;
using IABox.Views.Enterprises;
using IABox.Views.MenuNavigation;
using Newtonsoft.Json;
//using PassKit;
using System.Collections.Generic;
//using Java.Net;
//using Org.Apache.Http.Protocol;
//using Java.Nio.Channels;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using static System.Net.WebRequestMethods;
//using AppClip;

namespace IABox
{

    public partial class Login : ContentPage
    {
        #region Properties...
        private string host = Environment.GetEnvironmentVariable("ipLocal");
        private LogService _logService;
        public SessionDTO sessionInfo { get; private set; }
        #endregion
        public Login()
        {
            InitializeComponent();
            _logService = new LogService();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) || !string.IsNullOrEmpty(password.Text))
            {
                string _url = host + "/Security/Login";
                try
                {
                    
                    
                    LoginDTO loginData = new LoginDTO
                    {
                        loginName = username.Text,
                        pass = password.Text
                    };

                    string jsonBody = System.Text.Json.JsonSerializer.Serialize(loginData);

                    using (HttpClient client = new HttpClient())
                    {
                        StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(_url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();

                            if (string.IsNullOrEmpty(responseContent))
                            {
                                await DisplayAlert("Error", "Contraseña o usuario incorrecto", "Aceptar");
                            }
                            else
                            {
                                SessionDTO session = JsonConvert.DeserializeObject<SessionDTO>(responseContent);
                                await SecureStorage.Default.SetAsync("auth_Token", session.Token);
                                await SecureStorage.Default.SetAsync("auth_Expiration", session.Fechaexpiracion.ToString());

                                Dictionary<string, object> data = new Dictionary<string, object>();
                                data.Add("SessionData", session);


                                await Shell.Current.GoToAsync("/Enterprise", true, data);

                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", $"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}", "Aceptar");
                        }
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"Error en la solicitud: {ex.Message}", "Aceptar");
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "Los campos se encuentran vacios", "Aceptar");
            }
        }
       

    }
}