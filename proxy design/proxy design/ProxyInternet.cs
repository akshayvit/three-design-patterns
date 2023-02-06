using System;
namespace proxy_design
{
	public class ProxyInternet : Iinternet
	{
		private Iinternet internet = new RealInternet();
		public static  List<String> bannedsites = new List<String>();
		public ProxyInternet()
		{
			bannedsites.Add("xyz.com");
			bannedsites.Add("abc.com");
			bannedsites.Add("bad.com");

		}
		public void connect(String host,String port )
		{
			if(bannedsites.Contains(host.ToLower()))
			{
				throw new Exception("Banned site!!!");
			}
			else
			{
				internet.connect(host, port);
			}
		}
	}
}

