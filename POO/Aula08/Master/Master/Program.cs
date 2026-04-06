using Master;

/*Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPJ);*/

Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 12345));

var a = conta.ToString();
Console.WriteLine(a);

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("Cezar", 50145896322), 20000);

var b = pj.ToString();
Console.Write(b);

ContaPoupanca pp = new ContaPoupanca(666666, 66.66, new Pessoa("Lu",6658962145), 5, 0);


pp.Consulta();

Console.ReadKey();

