using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_em_C_.models
{
  public class Curso
  {
    public string Nome {get; set;}
    public List<Pessoa> Alunos {get; set;}

    public void AdicionarAluno(Pessoa aluno) {
      Alunos.Add(aluno);
    }
    public int ObterQuantidadeDeAlunosMatriculados() {
      int quantidade = Alunos.Count;
      return quantidade;
    }
    public bool Remover(Pessoa aluno) {
      return Alunos.Remove(aluno);
    }
    public void ListarAlunos() {
      Console.WriteLine($"Alunos do curso de: {Nome}");
      for (int count = 0; count < Alunos.Count; count++) {
        // string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
        string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
        Console.WriteLine(texto);
      }
    }
  }
}