namespace DotNetConf2019
{
	using DotNetConf2019.Features.Main;
	using Xamarin.Forms;

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainView();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
