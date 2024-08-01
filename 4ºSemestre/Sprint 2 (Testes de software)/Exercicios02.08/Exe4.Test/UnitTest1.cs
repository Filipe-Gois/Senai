namespace Exe4.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Inventario inventario = new();

            Produto produto = new() { };
            inventario.AdicionarProduto(produto);



            int valorEsperado = 1;


            Assert.Equal(valorEsperado, inventario.InventarioLista.Count);

        }
    }
}