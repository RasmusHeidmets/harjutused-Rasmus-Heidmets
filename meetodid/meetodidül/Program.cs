namespace meetodidül
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            string info = "";
            do
            {


                //kasutajalt info saamine
                Console.WriteLine("palun sisesta filtreeriva lähteinfo");
                info = GetResponse();
                Console.WriteLine("palun sisestage otsitav info:");
                string searchthisword = "apelsin";

                //filtreerimine
                bool doeswordexist = FindThisWord(searchthisword, info);
                if (doeswordexist == true)
                {
                    Console.WriteLine("Leidsime sõna \"" + searchthisword + "\"sinu sisestatud infost:");
                    Console.WriteLine(info);
                }
                else
                {

                    Console.WriteLine("sõna\"" + searchthisword + "\" infost puudub");

                }
                //programmi töö kordamine
                RepeatAction();
            } while (vastus == "jah");

            do
            {
                Console.WriteLine("kas soovid infosse midagi lisada?");
                vastus = GetResponse();
                if (vastus == "jah") ;
                {
                    Console.WriteLine("kirjuta juurde lisatav info.");
                    info += GetResponse();
                }
                vastus = RepeatAction();
                while (vastus == "jah") ;

                vastus = "";
               


            } while (vastus == "jah");
            do
            {


                Console.WriteLine("Kas salvestad dokumendi töölauale, või dokumendikausta");
                string kuhu = GetResponse();
                string savefilehere = "";
                if (kuhu == "töölaud")
                {
                    savefilehere = "C:\\Users\\opilane\\Desktop\\info.txt";
                    File.WriteAllText(savefilehere, info);
                }
                else if (kuhu == "dokumendid")
                {
                    savefilehere = "C:\\Users\\opilane\\Documents\\info.txt";
                    File.WriteAllText(savefilehere, info);
                }
                else
                {
                    Console.WriteLine("ei saa aru,"+kuhu+"ei ole salvestatav asukoht");
                    vastus = RepeatAction();
                    File.WriteAllText(savefilehere, info);
                }

                

                } while (vastus == "jah");



                // programmi lõpp
                Console.WriteLine("Headaega");
            
        }
            
        private static  string RepeatAction()
        {
            Console.WriteLine("Kas tahad tegevust korrata?");
            string values = GetResponse();
            return values;
        }

        public static bool FindThisWord(string filter, string tobefiltered)
        {
            if (tobefiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();
            }
            return "";
        }
    }
}
