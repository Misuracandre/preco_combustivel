using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double alcool, gasolina;

        Console.WriteLine("Informe preço do alcool");
        alcool = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o preço da gasolina");
        gasolina = double.Parse(Console.ReadLine());

        if (alcool / gasolina < 0.7)
        {
            Console.WriteLine("O álcool está mais vantajoso.");
        }

        else
        {
            Console.WriteLine("A gasolina está mais vantajosa.");
        }
    }
}
