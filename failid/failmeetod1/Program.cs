namespace failmeetod1
{
    internal class Program
    {
        private static string filePath;

        static void Main(string[] args)
        {
            /*
             
             Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja kasutab keelatud sõnu, küsitakse kogu rida kasutajalt uuesti.
            kui küsimine on lõppenud, küsitakse kasutajalt failinime, ja luuletus salvestatakse faili
            pärast salvestust kuvatakse failisisu kasutajale tagasi.
             
             */
            int riduolemas = 0;
            string olemasolevsisu = "";
            while (riduolemas < 4)
            {
                Console.WriteLine("sisestage oma luuletus, salvesta see faili, ja vaata oma luuletus hiljem üle");
                List<string> keelatudsõnad = new List<string>() { "nigger", "epsitein fuck niggers", "diddy oil" };

                string hetkesisestus = "";
                while (hetkesisestus == "")
                {
                    hetkesisestus = ReadAnswer();


                    foreach (var ks in keelatudsõnad)
                    {
                        if (hetkesisestus.Contains(ks))
                        {
                            hetkesisestus = "";
                            Console.WriteLine("on leitud keelatud sõna, sisestus on tühistatud");
                        }
                    }
                }
                olemasolevsisu += ReadAnswer();
            }
            Console.WriteLine("sisestage failinimi kuhu soovite salvestada");
            string failinimi = ReadAnswer();
            string filePath ="C:\\Users\\opilane\\source\\repos\\harjutused Rasmus Heidmets\\failid\\failmeetod1\\" + failinimi + ".txt";
            File.WriteAllText(filePath, olemasolevsisu);
            DisplayLuuletus(filePath);

        }
        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readluuletus = new StreamReader(location))
            {
                while (readluuletus.EndOfStream == false)
                {
                    Console.WriteLine(readluuletus.ReadLine());
                }
                readluuletus.Close();
            }
        }
        public static string ReadAnswer()
        {
            string vastus = "";
            while (vastus== "")
            {
                Console.WriteLine("tee vastav sisestus : ");
                vastus = Console.ReadLine();
            }


            return vastus;
        }
    }
}
