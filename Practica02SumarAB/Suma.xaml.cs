namespace Practica02SumarAB;

public partial class Suma : ContentPage
{
	public Suma()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(numero1.Text) && !string.IsNullOrEmpty(numero2.Text))
        {
            double resultado, datoA, datoB;
            datoA = Convert.ToDouble(numero1.Text);
            datoB = Convert.ToDouble(numero2.Text);
            resultado = datoA + datoB;
            Resultado.Text = resultado.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduzca todos los numeros", "OK");
        }
    }
}