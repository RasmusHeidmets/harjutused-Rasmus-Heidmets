namespace file_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta siia oma postkasti aadress");
            string filepath = "C:\\Users\\opilane\\source\\repos\\harjutused Rasmus Heidmets\\failid\\file operation\\postkastaaadress.txt";
            string aadress = Console.ReadLine();

            File.WriteAllText(filepath, aadress);
        }
    }
}
