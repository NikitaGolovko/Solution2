using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBILite
{
	public class Calculator : Core.ICalc
	{
		public int Add(int number1, int number2)
		{
			Microsoft.Practices.Unity.UnityContainer container = new Microsoft.Practices.Unity.UnityContainer();
			return (number1 + number2);
		}

		public int Substract(int number1, int number2)
		{
			return (number1 - number2);
		}
	}
}
