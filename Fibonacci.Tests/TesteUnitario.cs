using Fibonacci.Dominio;
using System.Diagnostics;

namespace Fibonacci.Tests;
[TestCategory("Fibonacci")]
[TestClass]
public class TesteUnitario
{
	private Stopwatch relogio;
	private SequenciaFibonacci fibo;

	[TestInitialize]
	public void Inicializar()
	{
		relogio = new Stopwatch();
		fibo = new();
	}

	[TestMethod]
	public void DeveRetornarVerdadeiroParaZero()
	{
		bool resultado = fibo.EhFibonacci(0);
		Assert.IsTrue(resultado);
	}

	[TestMethod]
	public void DeveRetornarVerdadeiroParaUm()
	{
		bool resultado = fibo.EhFibonacci(1);
		Assert.IsTrue(resultado);
	}

	[TestMethod]
	public void DeveRetornarVerdadeiroParaVinteEUm()
	{
		bool resultado = fibo.EhFibonacci(21);
		Assert.IsTrue(resultado);
	}

	[TestMethod]
	public void DeveRetornarFalsoParaQuatro()
	{
		bool resultado = fibo.EhFibonacci(4);
		Assert.IsFalse(resultado);
	}

	[TestMethod]
	public void DeveRetornarFalsoParaNumeroNegativo()
	{
		bool resultado = fibo.EhFibonacci(-5);
		Assert.IsFalse(resultado);
	}

	[TestMethod]
	public void DeveRetornarVerdadeiroParaNumeroMuitoGrandeQuePertence()
	{
		bool resultado = fibo.EhFibonacci(2178309);
		Assert.IsTrue(resultado);
	}

	[TestMethod]
	public void DeveRetornarFalsoParaNumeroMuitoGrandeQueNaoPertence()
	{
		bool resultado = fibo.EhFibonacci(2178310);
		Assert.IsFalse(resultado);
	}

	[TestMethod]
	public void DeveTestarPerformanceParaNumeroPequenoComRecursao()
	{
		relogio.Start();
		int resultado = fibo.FibonacciPorRecursao(10);
		relogio.Stop();
		Assert.IsTrue(relogio.Elapsed < TimeSpan.FromMilliseconds(100));
		Debug.Print(relogio.Elapsed.ToString());
	}

	[TestMethod]
	public void DeveTestarPerformanceParaNumeroGrandeComRecursao()
	{
		relogio.Start();
		int resultado = fibo.FibonacciPorRecursao(2178309);
		relogio.Stop();
		Assert.IsTrue(relogio.Elapsed < TimeSpan.FromMilliseconds(100));
		Debug.Print(relogio.Elapsed.ToString());
	}

}
