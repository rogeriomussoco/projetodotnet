using System;

namespace Apprevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1" :
                        Console.WriteLine("informe nome do Aluno");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a Nota");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = Nota;
                        }
                        else
                        {
                            throw new ArgumentException("valor da nota deve ser decimal");
                        }

                        aluno[indiceAluno] = aluno;
                        indiceAluno++;

                    case "2":
                        //TODO:Listar alunos
                        break;

                    case "3":
                        //TODO: calcular media
                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("informe a opcao desejada");
            Console.WriteLine("1:Inserir novo aluno");
            Console.WriteLine("2:Listar alunos");
            Console.WriteLine("3:Calcular a média artimética geral");
            Console.WriteLine("X:Sair:");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }

}