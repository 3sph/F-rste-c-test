// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("heisann! hva heter du?");
        var input = Console.ReadLine();
        Console.WriteLine($"heisann: {input}");
    }
}
