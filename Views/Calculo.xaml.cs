namespace Quintana_AppApuntes.Views;

public partial class Calculo : ContentPage
{
	public Calculo()
	{
		InitializeComponent();
	}
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        string cadena = entrada.Text;
        int numeros = 0, letras = 0, vocales = 0, mayusculas = 0, minusculas = 0;

        foreach (char c in cadena)
        {
            if (char.IsDigit(c))
            {
                numeros++;
            }
            else if (char.IsLetter(c))
            {
                letras++;
                if ("AEIOUaeiou".IndexOf(c) != -1)
                {
                    vocales++;
                }
                if (char.IsUpper(c))
                {
                    mayusculas++;
                }
                else if (char.IsLower(c))
                {
                    minusculas++;
                }
            }
        }

        resultado.Text = $"Números: {numeros}\nLetras: {letras}\nVocales: {vocales}\nMayúsculas: {mayusculas}\nMinúsculas: {minusculas}\nTotal: {cadena.Length}";
    }

    private void Limpiar_Clicked(object sender, EventArgs e)
    {
        entrada.Text = "";
        resultado.Text = "";
    }
}
