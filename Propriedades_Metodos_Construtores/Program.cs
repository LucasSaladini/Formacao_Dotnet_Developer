using Propriedades_Metodos_Construtores.Models;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Saladini");

Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








// p1.Idade = 30;
// p1.Apresentar();