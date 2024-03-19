namespace clone;

public partial class TerceiraPage : ContentPage
{

	public TerceiraPage()
	{
		InitializeComponent();
	}
private void QuandoClicarGarrafa(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new QuartaPage();
	  }
   private void QuandoClicarMascara(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new QuintaPage();
	  }
   
}

