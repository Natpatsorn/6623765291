namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	private void GoToPage2(object sender,EventArgs e) 
	{
		Navigation.PushAsync(new NewPage2());
	}
	private void GoToPage3(object sender,EventArgs e) 
	{
		Navigation.PushAsync(new NewPage3());
	}

	

}