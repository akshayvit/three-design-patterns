namespace proxy_design
{
    public interface Iinternet { public void connect(string host,string port); }
    class Program
    {
        public static void Main(string[] args)
        {
            Iinternet internet = new ProxyInternet();
            try
            {
                internet.connect("google.com","8080");
                internet.connect("abc.com","8080");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}