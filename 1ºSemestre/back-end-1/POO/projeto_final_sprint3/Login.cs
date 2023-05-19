using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_sprint3
{
    public class Login
    {

        public bool Logado { get; set; }
        public string opcao { get; set; } = "";
        public string opcao2 { get; set; } = "";
        public string opcao3 { get; set; } = "";
        public string opcao4 { get; set; } = "";
        public string EmailInformado { get; set; } = "";
        public string SenhaInformada { get; set; } = "";
        Usuario user = new Usuario();


        public Login()
        {
            Usuario _user = new Usuario();
            MenuUsuario();

            Logar(_user);

            if (this.Logado == true)
            {
                Menu();
            }

        }

        public void Menu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            do
            {
                Console.WriteLine(@$"
            
            Informe a opção desejada:

            [1] - Produtos
            [2] - Marcas

            ---------------
            [0] - Sair

            ");

                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        do
                        {


                            Console.WriteLine(@$"
                    [1] - Cadastrar produto
                    [2] - Listar produtos
                    [3] - Remover produto

                    -----------------------

                    [0] - Voltar");

                            opcao2 = Console.ReadLine()!;
                            switch (opcao2)
                            {
                                case "1":
                                    produto.Cadastrar();
                                    break;

                                case "2":
                                    produto.Listar();
                                    break;

                                case "3":
                                    produto.Deletar();
                                    break;

                                case "0":

                                    break;


                                default:
                                    Console.WriteLine($"Opção inválida.");
                                    break;
                            }
                        } while (opcao2 != "0");
                        break;
                    case "2":
                        do
                        {


                            Console.WriteLine(@$"
                    [1] - Cadastrar marca
                    [2] - Listar marcas
                    [3] - Remover marca

                    -----------------------

                    [0] - Voltar");

                            opcao3 = Console.ReadLine()!;
                            switch (opcao3)
                            {
                                case "1":
                                    marca.CadastrarMarca();
                                    break;

                                case "2":
                                    marca.ListarMarca();
                                    break;

                                case "3":
                                    marca.DeletarMarca();
                                    break;

                                case "0":

                                    break;


                                default:
                                    Console.WriteLine($"Opção inválida.");
                                    break;
                            }
                        } while (opcao3 != "0");



                        break;

                    case "0":
                        Console.WriteLine($"\nAplicativo finalizado");
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine($"Opção inválida.");
                        break;
                }
            } while (opcao != "0");
        }

        public void Logar(Usuario user)
        {
            do
            {
                Console.WriteLine($"\nInforme seu Email: (clique duas vezes no 'enter' para acessar.)");
                EmailInformado = Console.ReadLine()!;

                Console.WriteLine($"Informe sua senha:");
                SenhaInformada = Console.ReadLine()!;


                if (EmailInformado == user.Email && SenhaInformada == user.Senha)
                {
                    this.Logado = true;
                    Console.WriteLine($"Acesso concedido.");
                }
                else
                {
                    this.Logado = false;
                    Console.WriteLine($"\nInformações inválidas.\n");

                }
            } while (EmailInformado != user.Email || SenhaInformada != user.Senha);



        }

        public void Delosgar()
        {

        }
        public void MenuUsuario()
        {

            Console.WriteLine(@$"Olá, informe a opção que desejada:
        
        [1] - Cadastrar nova conta
        [2] - Logar em uma conta já existente");

            opcao4 = Console.ReadLine()!;


            switch (opcao4)
            {
                case "1":
                    CadastrarUsuario();

                    break;

                case "2":

                    break;
                default:
                    Console.WriteLine($"Opção inválida.");

                    break;
            }
        }


        public void CadastrarUsuario()
        {
            Console.WriteLine($"Informe seu nome:");
            user.NomeUsuario = Console.ReadLine()!;

            Console.WriteLine($"\nInforme seu E-mail:");
            user.Email = Console.ReadLine()!;

            Console.WriteLine($"\nInforme uma senha:");
            user.Senha = Console.ReadLine()!;

            Console.WriteLine($"\nUsuário cadastrado!");

            user.DataCadastro = DateTime.Now;
            Console.WriteLine($"{user.DataCadastro}");

        }
    }
}