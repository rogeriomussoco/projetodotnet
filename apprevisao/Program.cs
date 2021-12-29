using System;

namespace Apprevisao
{
    class Program 
        {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO:adicionar aluno
                        break;

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
            Console.WriteLine("1:inserir novo aluno");
            Console.WriteLine("2: Calcular a média artimética geral");
            Console.WriteLine("X:Sair:");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }

}