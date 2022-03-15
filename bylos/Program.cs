using System;
using System.IO;  // include the System.IO namespace

namespace proj
{

    class Program
    {
        static void Main(string[] args)
        {
            string Direction = "Logs/";
            string Name = "LogFile.txt";
            Console.WriteLine("Irasykite kiek norite sukurti bylu:");
            Bylos obj = new Bylos();
            obj.Create();
            obj.Log(Direction, Name);
            obj.Delete();


         // string writeText = "Tekstas rasomas į bylą";
           //File.WriteAllText("darbas/random.txt", writeText);
           // nuskaitome tekstą
            //string readText = File.ReadAllText("darbas/irasas.txt");
            //Console.WriteLine(readText);
        }
    }
}

//https://www.techiedelight.com/determine-file-exists-csharp/ file exists
// https://www.delftstack.com/howto/csharp/generate-random-alphanumeric-strings-in-csharp/ random string generator