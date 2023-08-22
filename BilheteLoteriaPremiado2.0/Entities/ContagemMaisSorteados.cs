using System;
using System.Collections.Generic;
using System.Linq;

namespace BilheteLoteriaPremiado.Entities;

public class ContagemMaisSorteados
{
	public int[] CartelaCompleta { get; protected set; }

	public ContagemMaisSorteados() => CartelaCompleta = new int[60];

	public void SalvaTodosOsSorteios(List<int> resultado)
	{
		foreach (var item in resultado)
			CartelaCompleta[item - 1] += 1;
	}

	public List<int> RecuperaMaisSorteados(int qtdeDezenas)
	{
		var result = new List<int>();

		while (result.Count < qtdeDezenas)
		{
			var maisSorteado = CartelaCompleta.Max();
			var quantidadeMax = CartelaCompleta.Count(x => x == maisSorteado);

			if (quantidadeMax == 1)
			{
				var sorteado = CartelaCompleta.ToList().IndexOf(maisSorteado);
				result.Add(sorteado + 1);
				CartelaCompleta[sorteado] = 0;
			}
			else
			{
				var maxRepetidos = new List<int>();

				for (var index = 0; index < CartelaCompleta.Length; index++)
					if (CartelaCompleta[index] == maisSorteado)
						maxRepetidos.Add(index);

				var sorteadoEntreOsRepetidos = new Random().Next(maxRepetidos.Count);
				var randomDaLista = maxRepetidos[sorteadoEntreOsRepetidos];
				result.Add(randomDaLista + 1);
				CartelaCompleta[randomDaLista] = 0;
			}
		}

		return result;
	}

}
