using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public class Chromosome
	{
		public List<bool> Genes {
			get;
			set;
		}

		public double Fenotype {
			get {
				return CalculateFenotype();
			}
		}

		public Chromosome (int chromosomeLength, Random random)
		{
			Genes = 
				Enumerable
				.Range(0, chromosomeLength)
				.Select(n => Convert.ToBoolean(random.Next(0, 2)))
				.ToList();
		}

		private double CalculateFenotype()
		{
			double sum = 0;
			int i = Genes.Count() - 1;

			foreach (var item in Genes)
			{
				sum += Convert.ToInt16(item) * Math.Pow(2, i);
				i--;
			}

			return sum;
		}
	}
}

