namespace Fibonacci.Dominio;

public class SequenciaFibonacci
{
	public int FibonacciPorRecursao(int valor)
	{
		if (valor <= 1)
			return valor;
		return FibonacciPorRecursao(valor - 1) + FibonacciPorRecursao(valor - 2);
	}

	public bool EhFibonacci(int valor)
	{
		int i = 0;
		while (true)
		{
			int fib = FibonacciPorRecursao(i);
			if (fib == valor)
				return true;
			if (fib > valor)
				return false;
			i++;
		}
	}
	public void RealizarCalculo(int numero)
	{
		int valor = FibonacciPorRecursao(numero);
		if (EhFibonacci(numero))
		{
			Console.WriteLine($"{numero} pertence à sequência de Fibonacci.\n");
		}
		else
			Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.\n");
	}
}
