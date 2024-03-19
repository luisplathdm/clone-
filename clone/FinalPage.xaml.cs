namespace clone;

public partial class FinalPage : ContentPage
{

	public FinalPage()
	{
		InitializeComponent();
	}


 		private void QuandoClicarRecomecar(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new MainPage();
	  }
}