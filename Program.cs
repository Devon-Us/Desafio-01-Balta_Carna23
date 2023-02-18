internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Olá, digite a sua frase:");
        var frase = Console.ReadLine();
        System.Console.WriteLine($"Caracteres: {frase.Length}");
        System.Console.WriteLine($"Palavras: {frase.Split(' ').Length}");
    }
}