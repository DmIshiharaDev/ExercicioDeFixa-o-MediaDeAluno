using ExercicioDeFixação_MediaDeAluno;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULADORA DE MÉDIA ---");

        Aluno a;
        a = new Aluno();                

        Console.WriteLine();
        Console.Write("Nome do aluno: ");
        a.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno: (1° - max de 30.00 pontos / 2° - max 35.00 pontos / 3° - max 35.00 pontos)");
        Console.Write("Primeira nota: ");
        a.N1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Segunda nota: ");
        a.N2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
        Console.Write("Terceira nota: ");
        a.N3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float notafinal = a.NotaFinal();
        float ponto = 60 - a.NotaFinal();

        Console.WriteLine();
        Console.WriteLine("Nota final: " + notafinal.ToString("f2"), CultureInfo.InvariantCulture);
               
        if (notafinal > 60)
        {
            Console.WriteLine("Parabéns! Você está aprovado.");
        }
        else
        {
            Console.WriteLine("Que pena! Você foi reprovado.");
            Console.WriteLine("Faltaram " + ponto.ToString("f2", CultureInfo.InvariantCulture) +(" pontos."));
        }
    }
}