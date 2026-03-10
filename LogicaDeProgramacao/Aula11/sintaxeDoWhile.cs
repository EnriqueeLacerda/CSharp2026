using static System.Console;

int n = 0;

do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait(); // Pausa de 1 segundo para visualizar a contagem
}while (n < 5);
WriteLine("Fim Programa");