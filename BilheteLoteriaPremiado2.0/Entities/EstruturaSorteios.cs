using System;
using System.Collections.Generic;

namespace BilheteLoteriaPremiado.Entities;

public class EstruturaSorteios
{
	public int QuantidadeDezenas { get; }

	public EstruturaSorteios(int quantidadeDezenas) => QuantidadeDezenas = quantidadeDezenas;

	public List<int> RealizaSorteios()
	{
		var sorteioDoDia = new List<int>();
		var numRandomico = new Random();
		var indice = 0;

		do
		{
			var dezenaSorteada = numRandomico.Next(1, 60);
			if (!sorteioDoDia.Exists(x => x == dezenaSorteada))
			{
				sorteioDoDia.Add(dezenaSorteada);
				indice++;
			}
		}
		while (indice < QuantidadeDezenas);

		return sorteioDoDia;
	}

}
