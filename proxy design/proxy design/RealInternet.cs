using System;
namespace proxy_design
{
	public class RealInternet : Iinternet
	{
		public void connect(String host,String port)
		{
			Console.WriteLine("Connected to Real Internet at "+host+" "+port);
		}
	}
}

