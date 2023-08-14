namespace MauiApp5;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Member_Click(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MauiApp5.Pages.Member());
    }

    private async void MemberAC_Click(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MauiApp5.Pages.MemberAccess());
    }
}

