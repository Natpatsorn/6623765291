using MauiApp1.Classes;

namespace MauiApp1;

public partial class Assignment10 : ContentPage
{
	Cars No1;
	Cars No2;
	Cars No3;
	bool Finished = false;
	public Assignment10()
	{
		InitializeComponent();

		No1 = new Cars ("Aston Marin","Vantage",325,78,1000,12.2);
		No2 = new Cars ("Porsche","Panerama",302,90,1000,11.7);
		No3 = new Cars ("McLaren","750s",332,72,1000,11.2);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (!this.Finished)
		{
			var ScreenWidth = Application.Current.MainPage.Width;
			this.Cars1Run(ScreenWidth);
			this.Cars2Run(ScreenWidth);
			this.Cars3Run(ScreenWidth);
			this.InfoCars.Text = "1st Car"+ "\n" + No1.ShowInfoCar() + "\n" + "2nd Car"+ "\n" + No2.ShowInfoCar() + "\n" + "3rd Car"+ "\n" + No3.ShowInfoCar();
			this.Finished = true;
		}
		else
		{
			Image1.TranslateTo(0,0,0,Easing.Linear);
			Image2.TranslateTo(0,0,0,Easing.Linear);
			Image3.TranslateTo(0,0,0,Easing.Linear);
			this.Finished = false;
		}
    }
	
	private void Cars1Run (double distance)
	{
		var TimeUsed = No1.TimeUsedforDrive(distance);
		Image1.TranslateTo(distance-100,0,TimeUsed*500,Easing.Linear);
	}

	private void Cars2Run (double distance)
	{
		var TimeUsed = No2.TimeUsedforDrive(distance);
		Image2.TranslateTo(distance-100,0,TimeUsed*500,Easing.Linear);
	}

	private void Cars3Run (double distance)
	{
		var TimeUsed = No3.TimeUsedforDrive(distance);
		Image3.TranslateTo(distance-100,0,TimeUsed*500,Easing.Linear);
	}
}