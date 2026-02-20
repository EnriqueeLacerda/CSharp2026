using static System.Console;

int ano, mes, dia, diaDigitados;

WriteLine("digite o dia do seu nascimento");
dia = int.Parse(ReadLine());

ano = dia /365;
diaDigitados = dia % 365;
mes = diaDigitados % 365;
diaDigitados = diaDigitados % 30;

WriteLine($" você tem {ano} anos, {mes} meses e {diaDigitados} dias de vida");




