
using System;

namespace DefaultProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int varSwitch;
            int alter;
            string name;
            while (true)
            {
                Console.Write("Wie heißt du? ");
                name = Console.ReadLine();
                Console.Write("Wie alt bist du? ");
                alter = Convert.ToInt32(Console.ReadLine());

                if (alter < 12 && alter > 0)
                {
                    varSwitch = 1;
                    break;
                }
                else if (alter < 18 && alter >= 12 )
                {
                    varSwitch = 2;
                    break;
                }
                else if (alter >= 18)
                {
                    varSwitch = 3;
                    break;
                }
                else if (alter < 1) 
                {
                    Console.WriteLine("Invalides Alter!");
                }
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
