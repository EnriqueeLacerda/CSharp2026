/*  Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
 *  (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final 
 *  do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, 
 *  em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos)*/

using static System.Console;
using Aluno_Media;


WriteLine("Qual o nome do Aluno: ");
String NomeDoAluno = Console.ReadLine();

WriteLine("Digite a primeira Nota");
Double Nota1 = double.Parse(ReadLine());

WriteLine("Digite a primeira Nota");
Double Nota2 = double.Parse(ReadLine());

WriteLine("Digite a primeira Nota");
Double Nota3 = double.Parse(ReadLine());

Aluno p = new Aluno(NomeDoAluno, Nota1, Nota2,Nota3);


WriteLine($"Nota Final Do Aluno: {p.NotaFinal}");

ReadKey();