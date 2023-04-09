using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoPorSelecao
{
	public class Ordenador
	{
		public int[] OrdenarArray(int[] array)
		{
			int tamanhoDoArray = array.Length;
			int[] arrayOrdenado = new int[tamanhoDoArray];

			for (int i = 0; i < array.Length; i++)
			{
				int indiceDoMenor = i;
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[j] < array[indiceDoMenor])
					{
						indiceDoMenor = j;						
					}
				}

				int menor = array[indiceDoMenor];
				array[indiceDoMenor] = array[i];
				arrayOrdenado[i] = menor;
			}
			return arrayOrdenado;
		}
	}
}
