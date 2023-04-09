using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoPorSelecao
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 5, 4, 3, 2, 1};

			var ordenador = new Ordenador();
			var ordenado = ordenador.OrdenarArray(array);

			string printOrdenado = string.Join(", ", ordenado);

			Console.WriteLine("Array ordenado: [" + printOrdenado + "]");

			Console.ReadLine();			
		}
	}
}
