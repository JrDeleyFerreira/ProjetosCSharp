using AluraFilmesEntity.Model;
using System.Collections.Generic;

namespace AluraFilmesEntity.model
{
  public class Filme
  {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string AnoLancamento { get; set; } 
    public short Duracao { get; set; }
    public IList<FilmeAtor> AtoresFilme { get; set; }
    public Idiomas IdiomaFalado { get; set; }
    public Idiomas IdiomaOriginal { get; set; }

    /// <summary>
    /// Valor checked no banco
    /// </summary>
    public string TextoClassificacao { get; private set; }
    public ClassificacaoIndicativa Classificacao
    {
      get => TextoClassificacao.TextoParaEnum();
      set => TextoClassificacao = value.EnumParaString();
    }

    public Filme() => AtoresFilme = new List<FilmeAtor>();

    public override string ToString() => $"Filme ({Id}): {Titulo} - Ano de {AnoLancamento}";

  }
}
