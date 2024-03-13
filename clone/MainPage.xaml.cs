namespace clone;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


   private void QuandoClicarJogar(object sender, EventArgs args)
{
	Application.Current.MainPage = new SegundaPage();
}
  
    private void QuandoClicarInf(object sender, EventArgs args)
{

}
    private void QuandoClicarFrameSobre(object sender, EventArgs args)
			{
			FrameSobre.IsVisible = true;
			}

	private void ButtonVoltar(object sender, EventArgs args)
  	 	    {
		    FrameSobre.IsVisible = false;
	 	    }
}