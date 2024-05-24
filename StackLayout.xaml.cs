namespace ProyectoMAUI
{
    public partial class StackLayout : ContentPage
    {
        public StackLayout()
        {
            InitializeComponent();
        }
        private async void IrFlexLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}

