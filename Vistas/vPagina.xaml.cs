namespace gpaucarSemana2Tarea.Vistas;

public partial class vPagina : ContentPage
{
	public vPagina()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        int seguimiento1=Convert.ToInt32(txtSeguimiento1.Text);
        int examen1 = Convert.ToInt32(txtExamen1.Text);
        double promedio1 =((seguimiento1*0.3)+(examen1*0.2));

        if ( seguimiento1 >=00.01 && seguimiento1<=10)
        {

            DisplayAlert("Alerta", "nota  Parcial 1 : "+promedio1, "cerrar");
           
        }
        else
        {
            DisplayAlert("Alerta", "Las notas deben ser entre 0 y 10", "cerrar");
            txtSeguimiento1.Text = "";
            txtExamen1.Text = "";
        }
    }



    private void btnInicio2_Clicked(object sender, EventArgs e)
    {
        int seguimiento2 = Convert.ToInt32(txtSeguimiento1.Text);
        int examen2 = Convert.ToInt32(txtExamen1.Text);
        double promedio2 = ((seguimiento2 * 0.3) + (examen2 * 0.2));

       if (seguimiento2 >= 00.01 && seguimiento2 <= 10)
        {

            DisplayAlert("Alerta", "nota  Parcial 2 : " + promedio2, "cerrar");

        }
        else
        {
            DisplayAlert("Alerta", "Las notas deben ser entre 0 y 10", "cerrar");
            txtSeguimiento1.Text = "";
            txtExamen1.Text = "";
        }
    }

}