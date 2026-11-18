namespace Explorador;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnJugarClicked(object sender, EventArgs e)
    {
        ResultadoLabel.Text = "¡A jugar! Zona, bots y AWM listos";
    }
}
