using System;

namespace Lab1.Services
{
	public class CalcService : ICalcService
	{
		public int First { get; private set; }
		public int Second { get; private set; }

		public CalcService()
		{
			Random rnd = new Random(DateTime.Now.Millisecond);
			(First, Second) = (rnd.Next() % 10, rnd.Next() % 10);
		}

		public int Divide()
		{
			try
			{
				var divResult = First / Second;
				return divResult;
			}
			catch (DivideByZeroException)
			{
				return -1;
			}
		}

		public int Mult()
		{
			return First * Second;
		}

		public int Substr()
		{
			return First - Second;
		}

		public int Summ()
		{
			return First + Second;
		}
	}
}
