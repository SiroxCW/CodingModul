using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Wie ist dein Name: ");
        string varUsername = Console.ReadLine();
        Console.Write("Was ist dein Geburtsjahr: ");
        int varGeburtsjahr = Convert.ToInt32(Console.ReadLine());
        Console.Write("Welches Jahr haben wir: ");
        int varJahr = Convert.ToInt32(Console.ReadLine());
        int varAlter = varJahr - varGeburtsjahr;
        Console.WriteLine("Hallo " + varUsername + "!\nWir haben das Jahr " + varJahr + ". Da du im Jahr " + varGeburtsjahr + " Geboren bist, bist du " + varAlter + " Jahre alt.");
    }
}
