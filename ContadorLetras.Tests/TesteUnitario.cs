using ContadorLetras.Dominio;
using System.Diagnostics;

namespace ContadorLetras.Tests;
[TestCategory("ContadorLetra")]
[TestClass]
public class TesteUnitario
{
	private Stopwatch relogio;
	private ContadorCaractere contador;

	[TestInitialize]
	public void Inicializar()
	{
		relogio = new Stopwatch();
		contador = new ContadorCaractere();
	}

	[TestMethod]
	public void Testar_StringComAlgumasOcorrenciasDeA_DeveRetornarContagemCorreta()
	{
		int resultado = contador.ContarPorRegex("Amanhã é outro dia");
		Assert.AreEqual(3, resultado);
	}

	[TestMethod]
	public void Testar_StringSemOcorrenciasDeA_DeveRetornarZero()
	{
		int resultado = contador.ContarPorRegex("O céu está escuro");
		Assert.AreEqual(0, resultado);
	}

	[TestMethod]
	public void Testar_StringComMaiusculasEMinusculas_DeveRetornarContagemCorreta()
	{
		int resultado = contador.ContarPorRegex("AaAaAaAa");
		Assert.AreEqual(8, resultado);
	}

	[TestMethod]
	public void Testar_StringComCaracteresEspeciais_DeveContarSomenteA()
	{
		int resultado = contador.ContarPorRegex("A$@a!Aa %a?");
		Assert.AreEqual(5, resultado);
	}

	[TestMethod]
	public void Testar_StringVazia_DeveRetornarZero()
	{
		int resultado = contador.ContarPorRegex("");
		Assert.AreEqual(0, resultado);
	}

	[TestMethod]
	public void Testar_StringPequenaComMuitasOcorrenciasDeA_DeveRetornarContagemCorreta()
	{
		int resultado = contador.ContarPorRegex("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
		Assert.AreEqual(30, resultado);
	}

	[TestMethod]
	public void Testar_StringGrandeSemA_DeveRetornarZero()
	{
		int resultado = contador.ContarPorRegex("b".PadRight(1000000, 'b'));
		Assert.AreEqual(0, resultado);
	}

	[TestMethod]
	public void Testar_StringComNumerosELetras_DeveRetornarContagemCorretaDeA()
	{
		int resultado = contador.ContarPorRegex("a1A2a3b4A");
		Assert.AreEqual(4, resultado);
	}

	[TestMethod]
	public void Testar_StringComCaracteresUnicode_DeveRetornarContagemCorretaDeA()
	{
		int resultado = contador.ContarPorRegex("áâã a A");
		Assert.AreEqual(2, resultado);
	}

	[TestMethod]
	public void Testar_Performance_MetodoComRegex_DeveConcluirDentroDoLimiteDeTempo()
	{
		relogio.Start();
		int resultado = contador.ContarPorRegex(File.ReadAllText("Arquivo.txt"));
		relogio.Stop();
		Assert.AreEqual(624 * 6, resultado);
		Assert.IsTrue(relogio.Elapsed < TimeSpan.FromMilliseconds(100));
		Debug.Print(relogio.Elapsed.ToString());
	}
}