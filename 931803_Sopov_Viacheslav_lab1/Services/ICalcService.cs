using Lab1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Services
{
	public interface ICalcService
	{
		int First { get; }
		int Second { get; }
		int Summ();
		int Substr();
		int Divide();
		int Mult();
	}
}
