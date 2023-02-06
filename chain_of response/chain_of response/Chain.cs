using System;
namespace chain_of_response
{
	public class Chain
	{
        Processor nextproc;
		public Chain()
		{
            nextproc = new Negativenumber(new PositiveNumber(new ZeroNumber(null)));
		}
        public void processnumber(Number n)
        {
            try
            {
                nextproc.process(n);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
	}
	class Negativenumber : Processor
	{
		public Negativenumber(Processor nextproc) : base(nextproc)
		{

		}
		public void process(Number request)
		{
			if(request.getnumber()<0)
			{
				Console.WriteLine("Processed");
			}
			 else
			{
				base.process(request);
			}
		}
	}
    class ZeroNumber : Processor
    {
        public ZeroNumber(Processor nextproc) : base(nextproc)
        {

        }
        public void process(Number request)
        {
            if (request.getnumber() == 0)
            {
                Console.WriteLine("Processed");
            }
            else
            {
                base.process(request);
            }
        }
    }
    class PositiveNumber : Processor
    {
        public PositiveNumber(Processor nextproc) : base(nextproc)
        {

        }
        public void process(Number request)
        {
            if (request.getnumber() > 0)
            {
                Console.WriteLine("Processed");
            }
            else
            {
                base.process(request);
            }
        }
    }
}

