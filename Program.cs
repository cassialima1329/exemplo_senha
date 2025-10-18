string senhaDigitada;
string senhaCorreta = "123abc";

Console.Write("Digite sua senha...: ");
senhaDigitada = Console.ReadLine()!;

bool acertou = senhaDigitada == senhaCorreta;

if (acertou)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Senha correta!!!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROOOOOOOU!!!");
}

Console.ResetColor();
