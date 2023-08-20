using System.Collections.Generic;

namespace AluraFilmesEntity.model
{
  public class Idiomas
  {
    public byte Id { get; set; }
    public string Nome { get; set; }
    public IList<Filme> FilmeFalado { get; set; }
    public IList<Filme> FilmeOriginal { get; set; }

    public Idiomas()
    {
      FilmeFalado = new List<Filme>();
      FilmeOriginal = new List<Filme>();
    }

    public override string ToString() => $"Idioma ({Id}): {Nome}";
  }
}
