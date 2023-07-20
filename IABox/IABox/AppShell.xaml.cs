//using Android.Media;
using IABox.Views.Enterprises;
using IABox.Views.MenuNavigation;
using IABox.Views.Pages;

namespace IABox
{

	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute("Login", typeof(Login));
			Routing.RegisterRoute("Login/Enterprise", typeof(EnterpriseSelect));
			Routing.RegisterRoute("Login/Enterprise/FlyoutSamplePage", typeof(FlyoutSamplePage));
		}

	}
}