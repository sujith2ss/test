
namespace Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void NextButton_OnClicked(object sender, EventArgs e)
    {
        Dispatcher.Dispatch(() => { Navigation.PushAsync(new Test()); });
    }
}

