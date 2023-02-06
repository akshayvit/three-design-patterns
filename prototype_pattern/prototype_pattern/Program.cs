using System;
namespace prototype_pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client.getColor("Green").addColor();
            Client.getColor("Yellow").addColor();
        }
    }
}