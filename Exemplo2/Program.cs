using Exemplo2.Models;

Pessoa p1 = new Pessoa("Danilo", "Fernandes");
Pessoa p2 = new Pessoa("José", "Silva");

Curso Ingles = new Curso();
Ingles.Nome = "ingles";
Ingles.Alunos = new List<Pessoa>();

Ingles.AdicionarAluno(p1);
Ingles.AdicionarAluno(p2);
Ingles.ListarAlunos();














/*Pessoa p1 = new Pessoa();
p1.Nome = "Danilo";
p1.Sobrenome = "Fernandes";
p1.Idade = 30;
p1.Apresentar();*/