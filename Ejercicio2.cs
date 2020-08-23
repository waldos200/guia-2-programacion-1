using System;

class Ejercicio2
{
	static void Main(string [] args)
	{
		double caloria, peso, tiempo, calorias_ganadas;
		string actividad;
		
		peso = 70;
		
		Console.Write("Digite la actividad que a hecho: ");
		actividad = Console.ReadLine().ToLower();
		
		switch (actividad){
			case "dormir":
				Console.Write("Digite cuanto tiempo a hecho esta actividad en minutos: ");
				tiempo = Convert.ToDouble(Console.ReadLine());
				caloria = tiempo * 1.08;
				calorias_ganadas = caloria + peso;
				Console.WriteLine("Esta fue la actividad que realizo \"{0}\", este es el tiempo que lo hizo {1}min y estas son las calorias consumidas {2} este es el total de calorias {3}", actividad, tiempo, caloria, calorias_ganadas );
				break;
			case "sentado en reposo":
				Console.Write("Digite cuanto tiempo a hecho esta actividad en minutos: ");
				tiempo = Convert.ToDouble(Console.ReadLine());
				caloria = tiempo * 1.66;
				calorias_ganadas = caloria + peso;
				Console.WriteLine("Esta fue la actividad que realizo \"{0}\", este es el tiempo que lo hizo {1}min y estas son las calorias consumidas {2} este es el total de calorias {3}", actividad, tiempo, caloria, calorias_ganadas );
				break;
			default:
				caloria = 0;
				Console.WriteLine("Esa actividad no esta");
				break;
		}
	}
}