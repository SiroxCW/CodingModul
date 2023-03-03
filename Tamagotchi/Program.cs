using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace PyOutTestCS
{
    internal class Program
    {
        static bool SpaceGame(int speed)
        {
            string password = "HEALING1";
            bool varExec1 = true; bool varExec2 = true; bool varExec3 = true; bool varExec4 = true; bool varExec5 = true; bool varExec6 = true; bool varExec7 = true; bool varExec8 = true;
            string char1_1 = "0"; string char1_2 = "0"; string char1_3 = "0"; string char1_4 = "0"; string char1_5 = "0"; string char1_6 = "0"; string char1_7 = "0"; string char1_8 = "0";
            string char2_1 = "0"; string char2_2 = "0"; string char2_3 = "0"; string char2_4 = "0"; string char2_5 = "0"; string char2_6 = "0"; string char2_7 = "0"; string char2_8 = "0";
            string char3_1 = "0"; string char3_2 = "0"; string char3_3 = "0"; string char3_4 = "0"; string char3_5 = "0"; string char3_6 = "0"; string char3_7 = "0"; string char3_8 = "0";
            string char4_1 = "0"; string char4_2 = "0"; string char4_3 = "0"; string char4_4 = "0"; string char4_5 = "0"; string char4_6 = "0"; string char4_7 = "0"; string char4_8 = "0";
            string char5_1 = "0"; string char5_2 = "0"; string char5_3 = "0"; string char5_4 = "0"; string char5_5 = "0"; string char5_6 = "0"; string char5_7 = "0"; string char5_8 = "0";

            var random = new Random();
            var chars = new List<string> { "1", "A", "D", "E", "F", "G", "H", "I", "L", "N", "P", "R", "S" };
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (Convert.ToString(key.Key) == "Spacebar")
                    {
                        if (char3_1 == Convert.ToString(password[0]) && varExec1 == true)
                        {
                            varExec1 = false;
                        }
                        else if (char3_2 == Convert.ToString(password[1]) && varExec1 == false && varExec2 == true)
                        {
                            varExec2 = false;
                        }
                        else if (char3_3 == Convert.ToString(password[2]) && varExec2 == false && varExec3 == true)
                        {
                            varExec3 = false;
                        }
                        else if (char3_4 == Convert.ToString(password[3]) && varExec3 == false && varExec4 == true)
                        {
                            varExec4 = false;
                        }
                        else if (char3_5 == Convert.ToString(password[4]) && varExec4 == false && varExec5 == true)
                        {
                            varExec5 = false;
                        }
                        else if (char3_6 == Convert.ToString(password[5]) && varExec5 == false && varExec6 == true)
                        {
                            varExec6 = false;
                        }
                        else if (char3_7 == Convert.ToString(password[6]) && varExec6 == false && varExec7 == true)
                        {
                            varExec7 = false;
                        }
                        else if (char3_8 == Convert.ToString(password[7]) && varExec7 == false && varExec8 == true)
                        {
                            return true;
                        }
                        else { return false; }



                    }
                }
                Console.WriteLine();
                if (varExec1 == true) { char5_1 = char4_1; }
                if (varExec2 == true) { char5_2 = char4_2; }
                if (varExec3 == true) { char5_3 = char4_3; }
                if (varExec4 == true) { char5_4 = char4_4; }
                if (varExec5 == true) { char5_5 = char4_5; }
                if (varExec6 == true) { char5_6 = char4_6; }
                if (varExec7 == true) { char5_7 = char4_7; }
                if (varExec8 == true) { char5_8 = char4_8; }
                if (varExec1 == true) { char4_1 = char3_1; }
                if (varExec2 == true) { char4_2 = char3_2; }
                if (varExec3 == true) { char4_3 = char3_3; }
                if (varExec4 == true) { char4_4 = char3_4; }
                if (varExec5 == true) { char4_5 = char3_5; }
                if (varExec6 == true) { char4_6 = char3_6; }
                if (varExec7 == true) { char4_7 = char3_7; }
                if (varExec8 == true) { char4_8 = char3_8; }
                if (varExec1 == true) { char3_1 = char2_1; }
                if (varExec2 == true) { char3_2 = char2_2; }
                if (varExec3 == true) { char3_3 = char2_3; }
                if (varExec4 == true) { char3_4 = char2_4; }
                if (varExec5 == true) { char3_5 = char2_5; }
                if (varExec6 == true) { char3_6 = char2_6; }
                if (varExec7 == true) { char3_7 = char2_7; }
                if (varExec8 == true) { char3_8 = char2_8; }
                if (varExec1 == true) { char2_1 = char1_1; }
                if (varExec2 == true) { char2_2 = char1_2; }
                if (varExec3 == true) { char2_3 = char1_3; }
                if (varExec4 == true) { char2_4 = char1_4; }
                if (varExec5 == true) { char2_5 = char1_5; }
                if (varExec6 == true) { char2_6 = char1_6; }
                if (varExec7 == true) { char2_7 = char1_7; }
                if (varExec8 == true) { char2_8 = char1_8; }
                if (varExec1 == true) { char1_1 = chars[random.Next(chars.Count)]; }
                if (varExec2 == true) { char1_2 = chars[random.Next(chars.Count)]; }
                if (varExec3 == true) { char1_3 = chars[random.Next(chars.Count)]; }
                if (varExec4 == true) { char1_4 = chars[random.Next(chars.Count)]; }
                if (varExec5 == true) { char1_5 = chars[random.Next(chars.Count)]; }
                if (varExec6 == true) { char1_6 = chars[random.Next(chars.Count)]; }
                if (varExec7 == true) { char1_7 = chars[random.Next(chars.Count)]; }
                if (varExec8 == true) { char1_8 = chars[random.Next(chars.Count)]; }

                if (char1_1 == Convert.ToString(password[0])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_1 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_1 + "  "); }
                if (char1_2 == Convert.ToString(password[1])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_2 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_2 + "  "); }
                if (char1_3 == Convert.ToString(password[2])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_3 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_3 + "  "); }
                if (char1_4 == Convert.ToString(password[3])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_4 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_4 + "  "); }
                if (char1_5 == Convert.ToString(password[4])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_5 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_5 + "  "); }
                if (char1_6 == Convert.ToString(password[5])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_6 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_6 + "  "); }
                if (char1_7 == Convert.ToString(password[6])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_7 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_7 + "  "); }
                if (char1_8 == Convert.ToString(password[7])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char1_8 + "\n"); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char1_8 + "\n"); }

                if (char2_1 == Convert.ToString(password[0])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_1 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_1 + "  "); }
                if (char2_2 == Convert.ToString(password[1])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_2 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_2 + "  "); }
                if (char2_3 == Convert.ToString(password[2])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_3 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_3 + "  "); }
                if (char2_4 == Convert.ToString(password[3])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_4 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_4 + "  "); }
                if (char2_5 == Convert.ToString(password[4])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_5 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_5 + "  "); }
                if (char2_6 == Convert.ToString(password[5])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_6 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_6 + "  "); }
                if (char2_7 == Convert.ToString(password[6])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_7 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_7 + "  "); }
                if (char2_8 == Convert.ToString(password[7])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char2_8 + "\n"); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char2_8 + "\n"); }
                Console.BackgroundColor = ConsoleColor.Blue;
                if (char3_1 == Convert.ToString(password[0])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_1 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_1 + "  "); }
                if (char3_2 == Convert.ToString(password[1])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_2 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_2 + "  "); }
                if (char3_3 == Convert.ToString(password[2])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_3 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_3 + "  "); }
                if (char3_4 == Convert.ToString(password[3])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_4 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_4 + "  "); }
                if (char3_5 == Convert.ToString(password[4])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_5 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_5 + "  "); }
                if (char3_6 == Convert.ToString(password[5])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_6 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_6 + "  "); }
                if (char3_7 == Convert.ToString(password[6])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_7 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_7 + "  "); }
                if (char3_8 == Convert.ToString(password[7])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char3_8 + "\n"); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char3_8 + "\n"); }
                Console.BackgroundColor = ConsoleColor.Black;
                if (char4_1 == Convert.ToString(password[0])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_1 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_1 + "  "); }
                if (char4_2 == Convert.ToString(password[1])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_2 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_2 + "  "); }
                if (char4_3 == Convert.ToString(password[2])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_3 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_3 + "  "); }
                if (char4_4 == Convert.ToString(password[3])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_4 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_4 + "  "); }
                if (char4_5 == Convert.ToString(password[4])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_5 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_5 + "  "); }
                if (char4_6 == Convert.ToString(password[5])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_6 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_6 + "  "); }
                if (char4_7 == Convert.ToString(password[6])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_7 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_7 + "  "); }
                if (char4_8 == Convert.ToString(password[7])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char4_8 + "\n"); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char4_8 + "\n"); }

                if (char5_1 == Convert.ToString(password[0])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_1 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_1 + "  "); }
                if (char5_2 == Convert.ToString(password[1])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_2 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_2 + "  "); }
                if (char5_3 == Convert.ToString(password[2])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_3 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_3 + "  "); }
                if (char5_4 == Convert.ToString(password[3])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_4 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_4 + "  "); }
                if (char5_5 == Convert.ToString(password[4])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_5 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_5 + "  "); }
                if (char5_6 == Convert.ToString(password[5])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_6 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_6 + "  "); }
                if (char5_7 == Convert.ToString(password[6])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_7 + "  "); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_7 + "  "); }
                if (char5_8 == Convert.ToString(password[7])) { Console.ForegroundColor = ConsoleColor.Green; Console.Write(char5_8 + "\n"); Console.ForegroundColor = ConsoleColor.White; } else { Console.Write(char5_8 + "\n"); }
                Thread.Sleep(speed);
                Console.Clear();
            }
        }
        static void Input()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  >");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void PyOut(string pyfile)
        {
            var cmd = $"-u {pyfile}";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python.exe",
                    Arguments = cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
            process.ErrorDataReceived += Process_OutputDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.WaitForExit();
        }
        static void Main(string[] args)
        {
            Console.Title = $"Tamagotchi - Started Up - Successfully called {System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName}";
            Console.Title = "Tamagotchi - Main - Trying to call print_tama.py";
            Console.ForegroundColor = ConsoleColor.Green;
            PyOut("print_tama.py");
            Console.ForegroundColor = ConsoleColor.Red;
            PyOut("print_stats.py");
            Console.ForegroundColor = ConsoleColor.Blue;
            PyOut("print_options.py");
            Input();
            string varOption = Console.ReadLine();
            if (varOption == "01")
            {
                Console.Write("\n How much Heal do you need? ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Be careful when healing!");
                Console.ForegroundColor = ConsoleColor.White;
                Input();
                int varHealAmount = Convert.ToInt32(Console.ReadLine());
                bool varPassedGame = SpaceGame(1000 - (varHealAmount * 10));
                Console.WriteLine();
                Console.Clear();
                if (varPassedGame)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PyOut($"option_heal.py +{varHealAmount}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PyOut($"option_heal.py -{varHealAmount}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (varOption == "02")
            {
                PyOut("option_sleep.py");
            }
            else if (varOption == "03")
            {
                Console.WriteLine(" Email Server: ");
                Input();
                string email_server = Console.ReadLine();
                Console.WriteLine(" Email: ");
                Input();
                string email_email = Console.ReadLine();
                Console.WriteLine(" Email Passwort: ");
                Input();
                string email_password = Console.ReadLine();
                Console.WriteLine(" Email Port (leave blank for default): ");
                Input();
                string email_port = Console.ReadLine();
                if (email_port == "") { email_port = "587"; }
                PyOut($"option_speedtest.py {email_server} {email_email} {email_password} {email_port}");
            }
            else
            {
                Console.Write(" Invalid Input!");
            }
            Console.ReadKey();
        }

        static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
    }
}
