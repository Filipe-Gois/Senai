// Instância do objeto carrinho
using exemplo;

Carrinho carrinho = new Carrinho();

// Instanciar objetos da Classe Produto

Produto p1 = new Produto(1, "GTA V", 52.98f);
Produto p2 = new Produto(2, "Forza", 499.99f);
Produto p3 = new Produto(3, "Valorant", 15.49f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);


carrinho.Listar();

carrinho.Totalcarrinho();

carrinho.Remover(p2);
carrinho.Remover(p3);

carrinho.Listar();

carrinho.Totalcarrinho();

Console.WriteLine($"Agora, vamos atualizar um objeto.");

// criar um objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.Totalcarrinho();