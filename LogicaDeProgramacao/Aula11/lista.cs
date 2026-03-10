using static System.Console;
using static System.Linq.Enumerable;

// list

//unidimensional
// tamanho do array pode ser alterado dinamicamente
//permite membros duplicados


List <string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("joao");
nomes.Add("clodoaldo");

nomes.Remove("Maria"); // remove o nome "Maria" da lista

foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}


