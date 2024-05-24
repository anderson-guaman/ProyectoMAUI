namespace ProyectoMAUI;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private async void IrAbsoluteLayoutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}