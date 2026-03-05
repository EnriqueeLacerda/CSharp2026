using static System.Console;

// declaroção de variaveis

const int SENHAFIXA = 2002;

int senha, contagem = 0;

Write("Digite a senha: ");
senha = int.Parse(ReadLine());

while (senha != SENHAFIXA)
{
    if(contagem >= 3)
    {
        WriteLine("Acesso Negado!");
        break;
    }
    contagem++;
    WriteLine("senha invalida, Digite novamente:");
    senha = int.Parse(ReadLine());
}
if (contagem < 3)
{
    WriteLine("Acesso Permitido!");
}
else
{
    WriteLine("Acesso Negado!");
}