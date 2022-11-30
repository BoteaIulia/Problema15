using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Afisati in ordine crescatoare numerele");
		Console.Write("\n");
		int a;
		int b;
		int c;
		int aux;
		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("c = ");
		c = Convert.ToInt32(Console.ReadLine());
		if (a > b)
		{
			aux = a;
			a = b;
			b = aux;
		}
		if (a > c)
		{
			aux = a;
			a = c;
			c = aux;
		}
		if (b > c)
		{
			aux = b;
			b = c;
			c = aux;
		}
		Console.Write("Rezultat ordine crescatoare:   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(b);
		Console.Write(" ");
		Console.Write(c);
	}
}