using MauiApp5.Pages;

namespace MauiApp5;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        object value = InitializeComponent();
    }

    private object InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void Member_Click(object sender, EventArgs e)
    {
        object value = await Navigation.PushAsync(new Pages.Member());
    }

    private async void MemberAC_Click(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MemberAccess());
    }
}

internal class Navigation
{
    internal static Task<object> PushAsync(Member member)
    {
        throw new NotImplementedException();
    }

    internal static Task PushAsync(MemberAccess memberAccess)
    {
        throw new NotImplementedException();
    }
}

public class ContentPage
{
}