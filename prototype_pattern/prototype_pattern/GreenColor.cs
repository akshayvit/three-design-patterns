using System;
namespace prototype_pattern
{
	public class GreenColor : Color
	{
		public GreenColor()
		{
            this.colorname = "green";
		}

        public override void addColor()
        {
            Console.WriteLine("Color is now {0}", colorname);
        }
    }
}

