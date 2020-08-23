using System;

class Ejercicio3
{
	static void Main(string [] args)
	{
		int num1, num2, resultado;
		
		Console.WriteLine("Digite el primer numero: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite el segundo numero: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		if (num1 == num2) {
			resultado = num1 * num2;
		} else if (num1 > num2) {
			resultado = num1 - num2;
		} else {
			resultado = num1 + num2;
		}
		Console.WriteLine("Este es el resultado: " + resultado);
		
		if (resultado % 2 == 0){
			Console.WriteLine("El resultado es par");
		} else {
			Console.WriteLine("El resultado es impar");
		}
	}
}