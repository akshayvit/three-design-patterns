namespace chain_of_response
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chain ch = new Chain();
            for (int i = 0; i <= 4; i++) { Console.WriteLine("Input no: "); int n = Convert.ToInt32(Console.ReadLine()); ch.processnumber(new Number(n)); }
        }
    }
}