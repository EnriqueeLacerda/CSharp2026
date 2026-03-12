// dicionario 

using static System.Console;
Dictionary<string, int> pessoa = new Dictionary<string, int>() // chamando o tipo de chave e valor do dicionario

{
    {"joao", 20},
    {"maria", 30},
    {"pedro", 40}
};

// adicionando dados aos dicionarios 
pessoa.Add("joao", 54);
WriteLine(pessoa["joao"]);

