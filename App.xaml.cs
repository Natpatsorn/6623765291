using Assignment;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        
		MainPage = new Assignment10();
		//MainPage = new AppShell();
		//MainPage = new ContentPageDemo();
		//MainPage = new FlyoutPageDemo();
		//MainPage = new Calculator();
		//MainPage = new Assignment8();
	}
}