namespace AluraFilmesEntity.Model
{
  public class Pessoa
  {
    public byte Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }

    public override string ToString()
    {
      var tipo = GetType().Name;
      return $"{tipo} ({Id}): {Nome} {Sobrenome} --- Ativo? ({Ativo}) --- {Email}";
    }
  }
}
