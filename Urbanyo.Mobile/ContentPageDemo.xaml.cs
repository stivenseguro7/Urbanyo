namespace Urbanyo.Mobile;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void Button_Construir(object sender, EventArgs e)
    {
        var navigation = Application.Current.MainPage.Navigation;

        // Abrir la nueva p�gina
        navigation.PushAsync(new BuildPage());
    }
}