using POO_em_C_.models;

Pessoa p1 = new Pessoa(nome:"Italo", sobrenome:"Thiago");


Pessoa p2 = new Pessoa(nome:"Fulano", sobrenome:"Silva");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();