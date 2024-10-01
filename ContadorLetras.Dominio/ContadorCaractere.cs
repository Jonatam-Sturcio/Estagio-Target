namespace ContadorLetras.Dominio;

using System.Text.RegularExpressions;

public class ContadorCaractere
{
	public int ContarPorRegex(string conteudo)
	{
		Regex regex = new Regex("[aA]");
		return regex.Matches(conteudo).Count;
	}

	private bool PossuiIncidencia(string conteudo)
	{
		int resultado = ContarPorRegex(conteudo);

		if (resultado == 0)
			return false;
		else
			return true;
	}

	public void ContarIncidencias(string texto)
	{
		if (PossuiIncidencia(texto))
		{
			Console.WriteLine($"A quantidade de incidências da letra \"a\", seja ela maiúscula ou minúscula é: {ContarPorRegex(texto)}\n");
		}
		else
			Console.WriteLine("Não há incidências da letra \"a\" na frase.");
	}
}



