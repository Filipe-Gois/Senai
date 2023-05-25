using exemplo1.Controller;
using exemplo1.Model;
using exemplo1.View;

ProdutoView p2 = new ProdutoView();
Produto p = new Produto();
ProdutoController controller = new ProdutoController();

controller.Cadastrar();
controller.ListarProdutos();

