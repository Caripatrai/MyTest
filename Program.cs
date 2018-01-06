using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Programa03_01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//TODO: pedir numero
			//variables
			string dato;
			int valor;
			//pedir numero
			Console.WriteLine("pasame un numero");
			dato = Console.ReadLine ();
			valor = Convert.ToInt32 (dato);

			//mostrar	
			Console.WriteLine (valor * 2);

		}
	}
}
