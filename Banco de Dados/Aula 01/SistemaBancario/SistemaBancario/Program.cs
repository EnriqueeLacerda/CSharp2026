using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contexto;

using var context = new BancoContext();


//veric se o db existe e cria se necessario
// cria as tabelas baseadas na entidades configuradas

context.Database.EnsureCreated();

//Menu no programa

Console.WriteLine("=== sistema Bancario ===");
Console.WriteLine("\n ---- Menu Principal ---");
Console.WriteLine("1 - Cadastrar nova conta");
Console.WriteLine("2 - consulta conta existente");
Console.WriteLine("3 - Sair\n");
Console.WriteLine("escolha uma opção: ");