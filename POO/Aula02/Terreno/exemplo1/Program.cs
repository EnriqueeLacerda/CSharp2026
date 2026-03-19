using exemplo1;
using static System.Console;




WriteLine("Entre com os dados do produto: ");
Write("nome:");
string nome = ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade:");
int qtd = int.Parse(ReadLine());

Produto p = new Produto(nome, preco, qtd);

WriteLine($"dados do produto {p.Dados_do_Produto()}");
WriteLine("digite a quantidade do produto a ser add");
qtd = int.Parse(ReadLine());
p.Adicionar_Produto(qtd);
WriteLine($"dados atualizados: {p.Dados_do_Produto()}");
WriteLine("digite a quantidade de produtos a ser removido do estoque:");
qtd = int.Parse(ReadLine());


p.Remover_Produtos(qtd);
WriteLine($"Dados atualizados: {p.Dados_do_Produto()}");
ReadKey();



