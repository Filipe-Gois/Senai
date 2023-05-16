using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_sprint3
{
    public class Login
    {
        string RespEmail;
        string RespSenha;
        public bool Logado { get; set; } = false;

        public Login()
        {
            Usuario user = new Usuario();


            do
            {
                Console.WriteLine($"Informe seu Email:");
                RespEmail = Console.ReadLine()!;

                Console.WriteLine($"Informe sua senha:");
                RespSenha = Console.ReadLine()!;

                if (RespEmail == user.Email && RespSenha == user.Senha)
                {
                    Console.WriteLine($"Acesso concedido.");
                    Logado = true;

                }
                else
                {
                    Console.WriteLine($"Informaões inválidas.");

                }
            } while (RespEmail != user.Email || RespSenha != user.Senha);
        }

        public void Menu()
        {
            Produto produto = new Produto();
            Console.WriteLine(@$"
            
            Informe a opção desejada:

            [1] - Adicionar produto
            [2] - Adicionar marca
            [3] - Listar produtos
            [4] - Listar marcas
            [5] - Remover produto
            [6] - Remover marca
            [7] - Sair
            ");

            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Informe o código do produto: ");
                    produto.CodigoProduto = int.Parse(Console.ReadLine()!);

                    


                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;





                default:
                    break;
            }
        }

        // public void Logar()
        // {

        //     Usuario user = new Usuario();


        //     do
        //     {
        //         Console.WriteLine($"Informe seu Email:");
        //         RespEmail = Console.ReadLine()!;

        //         Console.WriteLine($"Informe sua senha:");
        //         RespSenha = Console.ReadLine()!;

        //         if (RespEmail == user.Email && RespSenha == user.Senha)
        //         {
        //             Console.WriteLine($"Acesso concedido.");
        //             Logado = true;

        //         }
        //         else
        //         {
        //             Console.WriteLine($"Informaões inválidas.");

        //         }
        //     } while (RespEmail != user.Email || RespSenha != user.Senha);


        // }
    }
}