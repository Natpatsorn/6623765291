namespace MauiApp1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
	private void GoToPage1(object sender,EventArgs e)
	{
		Navigation.PushAsync(new NewPage1());
	}
private void GoToPage2(object sender,EventArgs e)
	{
		Navigation.PushAsync(new NewPage2());
	}

}