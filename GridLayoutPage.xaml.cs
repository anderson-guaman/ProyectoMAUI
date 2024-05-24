namespace ProyectoMAUI;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}
    private async void IrStackLayoutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayout());
    }

}