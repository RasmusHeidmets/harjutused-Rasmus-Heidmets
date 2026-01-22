using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace file_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("kirjuta siia oma postkasti aadress");
            //string filepath = "C:\\Users\\opilane\\source\\repos\\harjutused Rasmus Heidmets\\failid\\file operation\\postkastaaadress.txt";
            //string aadress = Console.ReadLine();

            //File.WriteAllText(filepath, aadress);

            Console.WriteLine("kõik laulu sõnad");
            //DisplayThisFile();

            FindWord("hot");
        }
        public static void FindWord(string findthisword)
        {
            using (StreamReader readFile = new StreamReader(
                "C:\\Users\\opilane\\source\\repos\\harjutused Rasmus Heidmets\\failid\\file operation\\laulusõnad.txt"
                ))
            {
                int lnr = 0;
                while (readFile.EndOfStream == false)
                {
                    string line = readFile.ReadLine();
                    foreach (var word Ain readFile.ReadLine())
                    {
                        if (line.Contains(findthisword) == true)
                        {
                            Console.WriteLine(findthisword + "leiti reast" + lnr);
                        }
                    }
                }
                readFile.Close();
            }
        }
        private static void DisplayThisFile()
        {
            string line = "";
            try
            {
                using (
                    StreamReader readThisThing = new StreamReader
               ("C:\\Users\\opilane\\source\\repos\\harjutused Rasmus Heidmets\\failid\\file operation\\laulusõnad.txt") )
                {
                    int linecount = 0;
                    while ( readThisThing.EndOfStream == false)
                    {
                        linecount++;
                        line = readThisThing.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(linecount + " " +line+ " . reapikkus on"+pikkus);
                    }
                    readThisThing.Close();
                }

            }
            catch (Exception e) 
            {
                Console.WriteLine("ei saa lugeda sest :" + e.Message);
                throw;
            }
        }
    }

}
