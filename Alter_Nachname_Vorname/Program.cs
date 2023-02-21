
using System;

namespace DefaultProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Wie ist dein Name: ");
                string varUsername = Console.ReadLine();
                Console.Write("Was ist dein Geburtsjahr: ");
                int varGeburtsjahr = Convert.ToInt32(Console.ReadLine());
                Console.Write("Welches Jahr haben wir: ");
                int varJahr = Convert.ToInt32(Console.ReadLine());
                int varAlter = varJahr - varGeburtsjahr;
                //Console.WriteLine("Hallo " + varUsername + "!\nWir haben das Jahr " + varJahr + ". Da du im Jahr " + varGeburtsjahr + " Geboren bist, bist du " + varAlter + " Jahre alt.");
                if (varAlter < 0)
                {
                    Console.WriteLine("Negatives Geburtsdatum.");
                    continue;
                }
                else if (varAlter == 0)
                {
                    Console.WriteLine("Frisch geschlüpft!");
                    break;
                }
                else if (varAlter < 20)
                {
                    Console.WriteLine("Du bist unter 20!");
                    break;
                }
                else if (varAlter < 30)
                {
                    Console.WriteLine("Du bist unter 30!");
                    break;
                }
                else if (varAlter >= 30)
                {
                    Console.WriteLine("Du bist 30 oder über 30!");
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
