using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proj
{
    public class Cons {
        public int Kiek = Convert.ToInt32(Console.ReadLine());
        
        public string Location = "darbas/";
        public Cons() { 
        }
    
    }

    internal class Bylos : Cons
    {
        public void Create() {
            string name1 = "A1.txt";
            string name2 = "a2.txt";
            Random rd = new Random();
            DirectoryInfo directory = new DirectoryInfo(Location);
            FileInfo[] files = directory.GetFiles();
            bool fileFound = false;
            foreach (FileInfo file in files) {
                if (String.Compare(file.Name, name1) == 0)
                {
                    System.IO.File.Move(Location + name1, Location + "A1"+DateTime.Now.ToString("MM/dd/yyyy")+".txt");
                }
                else { 
                }

                if (String.Compare(file.Name, name2) == 0)
                {
                    System.IO.File.Move(Location + name2, Location + "a2" + DateTime.Now.ToString("MM/dd/yyyy") + ".txt");
                }
                else
                {
                }

            }
            for (int j = 0; j < Kiek - 2; j++)
            {

                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);

                foreach (FileInfo file in files)
                {
                    if (String.Compare(file.Name, resultString) == 0)
                    {
                        System.IO.File.Move(Location + resultString, Location + resultString + DateTime.Now.ToString("MM/dd/yyyy") + ".txt");
                    }
                    else
                    {

                        int rand_num = rd.Next(0, 2);

                        string msg = "" + rand_num;
                        File.WriteAllText(Location + resultString + ".txt", msg);


                    }
                }
            }


        }



        public void Log(string Direction, string Name) {
            System.IO.Directory.CreateDirectory(Location + Direction);
            int zero = 0;
            int one = 0;
            int total;
            string [] files = Directory.GetFiles(@Location, "*.txt");
            foreach (var file in files) {
                string readText = File.ReadAllText(file);
                if (readText == "0")
                {
   
                    zero++;
                }
                else { 
                    one++;
                }
            }

            Console.WriteLine("Nuliai: " + zero);
            Console.WriteLine("vienetai: " + one);

            total = zero + one;

            string Rasyti = Location + " direktorijoje yra: " + total + " failų. Į " + zero + " failų yra įrašytas skaičius : 0, į likusius "
                + one + " failų yra įrašytas skaičius :1";

            File.WriteAllText(Location+Direction+Name, Rasyti);




        }


       public  void Delete() {
            string[] files = Directory.GetFiles(@Location, "*.txt");
            foreach (var file in files)
            {
                string readText = File.ReadAllText(file);
                if (readText == "0")
                {
                    File.Delete(file);
                }
               
            }






        }


    }
}
