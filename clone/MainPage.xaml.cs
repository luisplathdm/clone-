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
    private void QuandoClicarSobre(object sender, EventArgs args)
{

}
}