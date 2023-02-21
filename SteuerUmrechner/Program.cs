using System.IO;
using System;
using System.Collections.Generic;

namespace AufgabeDominik
{
    class Program
    {
        static void Main(string[] args)
        {
            int read_count = 0; // Read Counter for the End
            int write_count = 0; // Write Counter for the End
            string path = @"raw.txt";
            var list_lines_done = new List<string>();
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                read_count += 1;

                string[] list_line = s.Split('?');
                string list_element1 = list_line[0];
                string list_element2 = list_line[1];
                double list_element3 = Convert.ToDouble(list_line[2]);
                string list_element4 = list_line[3];
                string list_element5 = list_line[4];
                string list_element6 = list_line[5];
                int list_divide_number = 100 - Convert.ToInt32(list_element4);
                double list_element3_done = (list_element3 / 100) * list_divide_number;
                double list_element4_done = list_element3 - list_element3_done;
                string list_done = "" + list_element2 + ";" + list_element1 + ";" + list_element3_done + ";" + list_element4 + ";" + list_element4_done + ";" + list_element6;
                list_lines_done.Add(s);
                list_lines_done.Add(list_done);
            }

            using (StreamWriter writer = new StreamWriter("new_raw.txt"))
            {
                foreach (string i in list_lines_done)
                {
                    write_count += 1;
                    writer.WriteLine(i);
                }
                writer.WriteLine("Eingelesen " + read_count + " -> " + "Geschrieben " + write_count);
            }
        }
    }
}
