
using System;
using System.ComponentModel.Design;

namespace DefaultProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int varSwitch;
            Console.Write("Wie heißt du? ");
            string name = Console.ReadLine();
            Console.Write("Wie alt bist du? ");
            int alter = Convert.ToInt32(Console.ReadLine());

            if (alter < 12)
            {
                varSwitch = 1;
            }
            else if (alter <= 18)
            {
                varSwitch = 2;
            }
            else
            {
                varSwitch = 3;
            }

            switch (varSwitch) {
                case 1:
                    Console.WriteLine("Hallo " + name + "!\nDa du " + alter + " alt bist, kannst du folgene Spiele spielen:\nUno\nMinecraft\nKinderspiel");
                    break;
                case 2:
                    Console.WriteLine("Hallo " + name + "!\nDa du " + alter + " alt bist, kannst du folgene Spiele spielen:\nFortnite\nValorant\nCSGO");
                    break;
                case 3:
                    Console.WriteLine("Hallo " + name + "!\nDu kannst alle Spiele spielen!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
