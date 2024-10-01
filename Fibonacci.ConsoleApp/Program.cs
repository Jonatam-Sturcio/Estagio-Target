using Fibonacci.Dominio;

namespace Fibonacci.ConsoleApp;

internal class Program
{
	static void Main(string[] args)
	{
		SequenciaFibonacci fibo = new SequenciaFibonacci();

		int valorPertencente = 21;

		fibo.RealizarCalculo(valorPertencente);

		int valorNaoPertencente = 12;

		fibo.RealizarCalculo(valorNaoPertencente);
	}
}
