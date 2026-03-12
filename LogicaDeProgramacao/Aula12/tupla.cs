// tupla

var Clodoado = (34, 5000.34, "heitor","SENAI", 'B'); // chamado da tupla

Console.WriteLine($"Idade do Clodoado: {Clodoado.Item1}");
Console.WriteLine($"Nome do Filho do Clodoado: {Clodoado.Item3}");

Clodoado.Item1 = 54;
Console.WriteLine($"Idade do Clodoado: {Clodoado.Item1}");
