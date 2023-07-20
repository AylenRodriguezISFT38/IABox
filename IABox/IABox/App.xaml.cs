using IABox.Views.Enterprises;
using IABox.Views.MenuNavigation;

namespace IABox
{

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new AppShell();

			if (DeviceInfo.Platform == DevicePlatform.Android)
			{
				Environment.SetEnvironmentVariable("ipLocal", "http://10.0.2.2:45455");
			}
			else
			{
				Environment.SetEnvironmentVariable("ipLocal", "http://localhost:5001");
			}

			Environment.SetEnvironmentVariable("ipImagenes", "https://webaccess.iabox.com.ar");
		}
	}
}