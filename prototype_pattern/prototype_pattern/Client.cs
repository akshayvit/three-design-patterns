using System;
namespace prototype_pattern
{
	public class Client
	{
		private static Dictionary<String, Color> di;
		public Client()
		{
			di= new Dictionary<String, Color>();
			di["Yellow"] = new YellowColor();
			di["Green"] = new GreenColor();
		}
		public static Color getColor(String color) 
		{
			if(color=="Yellow")
			{
				return (Color) (new YellowColor()).Clone();

			}
			if(color=="Green")
			{
				return (Color) (new GreenColor()).Clone();
			}
			return null;
		}
	}
}