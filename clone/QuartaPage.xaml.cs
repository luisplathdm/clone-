namespace clone;

public partial class QuartaPage : ContentPage
{

	public QuartaPage()
	{
		InitializeComponent();
	}


 		private void QuandoClicarRecomecar(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new MainPage();
	  }
}