using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream aw = new FileStream(@"C:\Users\админ\Documents\pp2_files\task4_create.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter ar = new StreamWriter(aw);

            string line = "abcdefg";

            ar.WriteLine(line);
            ar.Close();
            aw.Close();

            File.Copy(@"C:\Users\админ\Documents\pp2_files\task4_create.txt", @"C:\Users\админ\Documents\pp2_files\task4_copy.txt");

            File.Delete(@"C:\Users\админ\Documents\pp2_files\task4_create.txt");

        }
    }
}
