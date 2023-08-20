using AluraFilmesEntity.controller;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AluraFilmesEntity
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var contexto = new AluraFilmesContext())
      {
        ListaDezAtoresModificadosRecente(contexto);

        ElencoAtoresDoPrimeiroFilme(contexto);

        /** Para criar restrições do tipo check com o EntityFramework, deve-se pegar o script 
         * que adiciona (ADD) a CONSTRAINT na base de dados, criar uma Migration vazia:
         * Up => Colocar o comando numa var e passá-la em migrationBuilder.Sql()
         * Down => Passar o DROP nessa mesma função */

        AtoresMaisAtuantes(contexto);

        ExecutandoComandosDeStoryProcedures(contexto);
      }
    }

    private static void ExecutandoComandosDeStoryProcedures(AluraFilmesContext contexto)
    {
      var categoria = "Action";
      var paramCategoria = new SqlParameter("category_name", categoria);
      var paramTotal = new SqlParameter
      {
        ParameterName = "total_actors",
        Size = 4,
        Direction = System.Data.ParameterDirection.Output
      };

      /** O 1º argumento é o nome da Story Procedure na base
       * Caso queira usar interpolação - ${} - basta usar: ExecuteSqlInterpolated() */
      contexto.Database.ExecuteSqlRaw(
        "total_actors_from_given_category @category_name, @total_actors OUT",
        paramCategoria, paramTotal);

      Console.WriteLine($"A quantidade de atores na categoria {categoria} é de: {paramTotal.Value}.");
    }

    private static void AtoresMaisAtuantes(AluraFilmesContext contexto)
    {
      UsandoLinqIneficiente(contexto);

      UsandoSqlManual(contexto);
    }

    private static void UsandoSqlManual(AluraFilmesContext contexto)
    {
      // A view na base estará construída assim
      var viewBanco = @"SELECT TOP 5 a.actor_id, a.first_name, a.last_name, COUNT(fa.film_id) as TOTAL 
                          FROM actors a 
                            INNER JOIN film_actor fa 
                              ON fa.actor_id = a.actor_id 
                        GROUP BY a.actor_id, a.first_name, a.last_name 
                        ORDER BY TOTAL DESC";

      // No lugar da interpolação, é usado o nome definido para a view
      var sql = @$"SELECT a.* FROM actors a 
                    INNER JOIN {viewBanco} filmes
                          ON filmes.actor_id = a.actor_id";

      var maisAtuantesComSql = contexto.Atores.FromSqlRaw(sql).Include(a => a.Filmografia);
      maisAtuantesComSql.ToList()
        .ForEach(ator => Console.WriteLine($"O Ator {ator.Nome} {ator.Sobrenome} atou em: {ator.Filmografia.Count} filmes."));
    }

    private static void UsandoLinqIneficiente(AluraFilmesContext contexto)
    {
      var atoresMaisAtuantes =
          contexto.Atores
            .Include(a => a.Filmografia)
            .OrderByDescending(a => a.Filmografia.Count)
            .Take(5);

      atoresMaisAtuantes.ToList()
        .ForEach(ator => Console.WriteLine($"O Ator {ator.Nome} {ator.Sobrenome} atou em: {ator.Filmografia.Count} filmes."));
    }

    private static void ElencoAtoresDoPrimeiroFilme(AluraFilmesContext contexto)
    {
      var filme =
          contexto.Filmes
            .Include(f => f.AtoresFilme)
            .ThenInclude(fa => fa.Ator)
            .First();

      Console.WriteLine(filme + "\n");
      Console.WriteLine("Elenco: ");
      filme.AtoresFilme.ToList().ForEach(ator => Console.WriteLine(ator.Ator));
    }

    private static void ListaDezAtoresModificadosRecente(AluraFilmesContext contexto)
    {
      var atores =
          contexto.Atores
            .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
            .Take(10);

      atores.ToList().ForEach(ator => Console.WriteLine(ator));
    }
  }
}
