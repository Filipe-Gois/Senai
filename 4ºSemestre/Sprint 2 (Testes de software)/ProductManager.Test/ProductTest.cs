using Moq;
using WebApiProductManager.Domains;
using WebApiProductManager.Interfaces;
using WebApiProductManager.Repository;
using WebApiProductManager.ViewModels.ProductViewModels;

namespace ProductManager.Test
{
    public class ProductTest
    {
        /// <summary>
        /// Teste para a funcionalidade de listar todos os produtos
        /// </summary>


        //cria um obj de simulação do tipo productrepository
        private readonly Mock<IProductRepository> mockRepository = new();

        [Fact]
        public void Get()
        {

            List<ExibirProduto> produtos = [

                new() { IdProduct = Guid.NewGuid(), Name= "Teste 1", Price = 100 },
                new() { IdProduct = Guid.NewGuid(),  Name= "Teste 2", Price = 200 },
                new() { IdProduct = Guid.NewGuid(),  Name= "Teste 3", Price = 300 },

        ];

            //cria um obj de simulação do tipo productrepository
            //Mock<IProductRepository> mockRepository = new();

            //Configura o metodo "ListarTodosProdutos" para que quando acionado, retorne a lista mockada
            mockRepository.Setup(x => x.ListarTodosProdutos()).Returns(produtos);

            //act

            //executando o metodo e atribue a resposta em result

            List<ExibirProduto> result = mockRepository.Object.ListarTodosProdutos();

            //assert

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void GetById()
        {
            ExibirProduto produto = new()
            {
                IdProduct = Guid.NewGuid(),
                Name = "teste 1",
                Price = 100
            };

            mockRepository.Setup(x => x.BuscarProdutoPorId(produto.IdProduct)).Returns(produto);


            ExibirProduto result = mockRepository.Object.BuscarProdutoPorId(produto.IdProduct);



            Assert.Equal(result, produto);
        }

        [Fact]
        public void Post()
        {

            List<CadastrarProduto> produtos = [];
            CadastrarProduto cadastrarProduto = new()
            {
                Name = "teste 1",
                Price = 100
            };


            //produtos.Add(cadastrarProduto

            mockRepository.Setup(x => x.Cadastrar(cadastrarProduto)).Callback(() => produtos.Add(cadastrarProduto));

            mockRepository.Object.Cadastrar(cadastrarProduto);

            Assert.Equal(1, produtos.Count);
        }

        [Fact]

        public void Delete()
        {

            List<ExibirProduto> produtos = [


              new()  {
                IdProduct = Guid.NewGuid(),
                Name = "teste 1",
                Price = 100
            },
                ];
            ExibirProduto produto = new()
            {
                IdProduct = Guid.NewGuid(),
                Name = "teste 2",
                Price = 200
            };

            produtos.Add(produto);

            mockRepository.Setup(x => x.Deletar(produto.IdProduct)).Callback(() => produtos.Remove(produto));

            mockRepository.Object.Deletar(produto.IdProduct);

            Assert.Equal(1, produtos.Count);
        }

        [Fact]
        public void Put()
        {
            ExibirProduto exibirProduto = new()
            {
                IdProduct = Guid.NewGuid(),
                Name = "Teste 1",
                Price = 100
            };

            AtualizarProduto atualizarProduto = new()
            {
                Name = "Teste  refeito",
                Price = 999
            };

            mockRepository.Setup(x => x.Atualizar(exibirProduto.IdProduct, atualizarProduto)).Callback(() =>
            {
                exibirProduto.Name = atualizarProduto.Name;
                exibirProduto.Price = atualizarProduto.Price;
            });

            mockRepository.Object.Atualizar(exibirProduto.IdProduct, atualizarProduto);


            Assert.Equal(exibirProduto.Name, "Teste  refeito");
            Assert.Equal(exibirProduto.Price, 999);
        }
    }
}