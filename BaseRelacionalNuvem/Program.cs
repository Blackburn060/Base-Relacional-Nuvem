class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Inserir Curso");
            Console.WriteLine("2 - Inserir Estudante");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirCurso();
                    break;
                case "2":
                    InserirEstudante();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void InserirCurso()
    {
        using (var context = new dbContext())
        {
            Console.Write("Nome do Curso: ");
            string nomeCurso = Console.ReadLine();

            var curso = new Curso
            {
                Nome = nomeCurso
            };

            context.Curso.Add(curso);
            context.SaveChanges();

            Console.WriteLine($"Curso '{nomeCurso}' inserido com sucesso!");
        }
    }

    static void InserirEstudante()
    {
        using (var context = new dbContext())
        {
            Console.Write("Nome do Estudante: ");
            string nomeEstudante = Console.ReadLine();

            Console.Write("Idade do Estudante: ");
            int idadeEstudante;
            while (!int.TryParse(Console.ReadLine(), out idadeEstudante))
            {
                Console.WriteLine("Idade inválida. Tente novamente.");
            }

            Console.Write("ID do Curso para Associar o Estudante: ");
            int idCurso;
            while (!int.TryParse(Console.ReadLine(), out idCurso))
            {
                Console.WriteLine("ID do Curso inválido. Tente novamente.");
            }

            var estudante = new Estudante
            {
                Nome = nomeEstudante,
                Idade = idadeEstudante
            };

            var curso = context.Curso.Find(idCurso);
            if (curso != null)
            {
                curso.Estudantes.Add(estudante);
                context.SaveChanges();
                Console.WriteLine($"Estudante '{nomeEstudante}' associado ao Curso '{curso.Nome}' com sucesso!");
            }
            else
            {
                Console.WriteLine($"Curso com ID {idCurso} não encontrado.");
            }
        }
    }
}
