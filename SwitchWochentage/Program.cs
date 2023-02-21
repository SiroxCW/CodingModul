
using System;

namespace DefaultProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool varExit;
            while (true)
            {
                varExit = false;
                Console.Write("Bitte gebe einen Wochentag in Zahl ein: ");
                int varTag = Convert.ToInt16(Console.ReadLine());

                switch (varTag)
                {
                    case 1:
                        Console.WriteLine("Es ist Montag!");
                        varExit = true;
                        break;
                    case 2:
                        Console.WriteLine("Es ist Dienstag!");
                        varExit = true;
                        break;
                    case 3:
                        Console.WriteLine("Es ist Mittwoch!");
                        varExit = true;
                        break;
                    case 4:
                        Console.WriteLine("Es ist Donnerstag!");
                        varExit = true;
                        break;
                    case 5:
                        Console.WriteLine("Es ist Freitag!");
                        varExit = true;
                        break;
                    case 6:
                        Console.WriteLine("Es ist Samstag!");
                        varExit = true;
                        break;
                    case 7:
                        Console.WriteLine("Es ist Sonntag!");
                        varExit = true;
                        break;
                    default:
                        Console.WriteLine("Kein valider Tag angegeben!");
                        break;
                }
                if (varExit == true)
                {
                    break;
                }

            }


            Console.ReadKey();
        }
    }
}
