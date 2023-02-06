using System;
namespace prototype_pattern
{
	public abstract class Color : ICloneable
	{
		public String colorname;
		public  abstract void addColor(); 
		public object Clone()
		{
			object? color=null;
			try
			{

				color=base.MemberwiseClone();
			}
			catch(Exception e)
			{
				Console.WriteLine(e);
			}
			return color;
		}
	}
	
}

