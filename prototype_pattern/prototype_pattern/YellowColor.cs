using System;
namespace prototype_pattern
{
    public class YellowColor : Color
    {
        public YellowColor()
        {
            this.colorname = "yellow";
        }

        public override void addColor()
        {
            Console.WriteLine("Color is now {0}", colorname);
        }
    }
}


