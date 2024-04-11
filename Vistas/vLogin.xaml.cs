namespace gpaucarSemana2Tarea.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = "uisrael";
        string contrasena = "12345";

        if (usuario == txtUsuario.Text && contrasena == txtcontrasena.Text)
        {
            Navigation.PushAsync(new vPagina());
        }
        else
        {
            DisplayAlert("Alerta", "Usuario & Contarseña incorectos", "cerrar");
            txtUsuario.Text = "";
            txtcontrasena.Text = "";
        }
    }
}