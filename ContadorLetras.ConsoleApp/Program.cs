using ContadorLetras.Dominio;

namespace ContadorLetras.ConsoleApp;

internal class Program
{
	static void Main(string[] args)
	{
		ContadorCaractere contador = new ContadorCaractere();

		string textoComA =
			"Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código";

		Console.WriteLine($"A frase é: {textoComA}");

		contador.ContarIncidencias(textoComA);

		string textoSemA =
			"O céu se mostrou nebuloso";

		Console.WriteLine($"A frase é: {textoSemA}");

		contador.ContarIncidencias(textoSemA);
	}
}
