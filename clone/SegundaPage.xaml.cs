using Microsoft.Maui.Controls;

namespace clone;

public partial class SegundaPage : ContentPage
{

	public SegundaPage()
	{
		InitializeComponent();
	}

 
 		private void QuandoClicarContinuar(object sender, EventArgs args)
	  {
	    Application.Current.MainPage = new TerceiraPage();
	  }
   
}

