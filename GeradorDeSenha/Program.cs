using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Gerador de Senha");

Console.WriteLine("Digite o tamanho da sua senha:");
int tamanhoDaSenha = int.Parse (Console.ReadLine());

string senha = GerarSenha(tamanhoDaSenha);

Console.WriteLine($"Senha Gerada:{senha}");



string GerarSenha(int tamanhoDaSenha)
{

    string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxwyz0123456789";

   char[] senha =  new char[tamanhoDaSenha];

   Random aleatrio = new Random();

    for (int i = 0; i < tamanhodasenha; i++)
{
    senha[i]= caracteres [aleatrio.Next(0, caracteres.Length)];
}

}
