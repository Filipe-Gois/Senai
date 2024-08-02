namespace Exe4.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Inventario inventario = new();

            Produto produto = new()
            {
                Nome = "teste1",

            }; Produto produto2 = new()
            {
                Nome = "teste2",

            };


            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto2);

            int valorEsperado = 2;


            Assert.Equal(valorEsperado, inventario.InventarioLista.Count);

        }

        [Fact]
        public void Test2()
        {
            Inventario inventario = new();

            Produto produto = new()
            {
                Nome = "teste1",

            }; Produto produto2 = new()
            {
                Nome = "teste2",

            };

            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto);
            inventario.AdicionarProduto(produto2);



            int valorEsperado = 4;
            int quantidadeDoProdutoBuscado = inventario.BuscarQuantidadeDoProdutoPeloNome(produto.Nome);

            Assert.Equal(valorEsperado, quantidadeDoProdutoBuscado);
        }
    }
}