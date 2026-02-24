
using static System.Console;

double produto, quantidade, dinheiro, pagar, troco;

Write("Por Favor digite o valor do produto:");
produto = double.Parse(ReadLine());

Write("Por Favor digite a quantidade de produtos:");
quantidade = double.Parse(ReadLine());

Write("Por Favor digite o valor Recebido:");
dinheiro = double.Parse(ReadLine());

pagar = produto * quantidade;
troco = dinheiro - pagar;
WriteLine();

WriteLine($"troco no valor de R$:{troco}");





