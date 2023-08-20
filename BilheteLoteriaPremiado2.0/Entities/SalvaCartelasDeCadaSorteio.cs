﻿using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BilheteLoteriaPremiado.Entities;

public class SalvaCartelasDeCadaSorteio
{
	private List<string> CanhotosSorteios { get; }
	public SalvaCartelasDeCadaSorteio() => CanhotosSorteios = new List<string>();

	internal List<string> CriaArquivoCanhotos(List<int> cartelaSorteada)
	{
		foreach (var item in cartelaSorteada)
		{
			if (item.ToString().Length != 1)
				CanhotosSorteios.Add($"{item}");
			else
				CanhotosSorteios.Add($"0{item}");
		}
		return CanhotosSorteios;
	}

	public static void SalvaSorteiosEmArquivo(List<string> sorteios, int qtdeSorteios)
	{
		var caminhoArquivo = @"C:\sorteios\refactorBilhetesSorteados.txt";

		using var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create);
		using var streamWriter = new StreamWriter(fluxoDeArquivo, Encoding.UTF8);
		var quebraLinha = sorteios.Count / qtdeSorteios;

		for (var i = 0; i < sorteios.Count; i++)
		{
			if (i != 0 && i % quebraLinha == 0)
				streamWriter.WriteLine("\n");
			streamWriter.Write($"{sorteios[i]} ");
		}
	}
}
