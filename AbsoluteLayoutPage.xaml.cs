namespace ProyectoMAUI;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}
    private async void IrGridLayoutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutPage());
    }
}