namespace clone;

public partial class QuintaPage : ContentPage
{

	public QuintaPage()
	{
		InitializeComponent();
	}
private void QuandoClicarDedo(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new FinalPage();
	  }
}

