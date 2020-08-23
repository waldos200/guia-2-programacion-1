using System;

class Ejercicio1
{
	static void Main(string [] args)
	{
		int edad, anio_trabajo;
		
		Console.Write("Digite su edad: ");
		edad = Convert.ToInt32(Console.ReadLine());
		Console.Write("Digite cuantos años tiene trabajando: ");
		anio_trabajo = Convert.ToInt32(Console.ReadLine());
		
		if (edad >= 60 && anio_trabajo < 25) {
			Console.WriteLine("La persona es candidato para jubilarse por edad");
		} else if (edad < 60 && anio_trabajo >= 25){
			Console.WriteLine("La persona es candidato para jubilarse por antigüedad joven");
		} else if (edad >= 60 && anio_trabajo >= 25){
			Console.WriteLine("LA persona es candidata para jubilarse por antigüedad adulta");
		} else {
			Console.WriteLine("La persona aun no se tiene que jubilar");
		}
	}
}