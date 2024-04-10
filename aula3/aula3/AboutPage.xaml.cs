namespace aula3;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://github.com/gabrieu5563");
	}
	
}