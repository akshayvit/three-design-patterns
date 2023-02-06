using System;
namespace chain_of_response
{
	public abstract class Processor
	{
		public Processor nextprocessor;

		public Processor(Processor nextproc)
		{
			this.nextprocessor = nextproc;
		}
		public void process(Number request)
		{
			 nextprocessor.process(request);
		}
	}
}