namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void GoToPage1(object sender,EventArgs e)
	{
		Navigation.PushAsync(new NewPage1());
	}
	private void GoToPage3(object sender,EventArgs e)
	{
		Navigation.PushAsync(new NewPage3());
	}

}