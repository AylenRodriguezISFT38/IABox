using IABox.Views.MenuNavigation;

namespace IABox
{

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Login();

		}
	}
}
