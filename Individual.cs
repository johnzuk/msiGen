using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public class Individual
	{
		public Func<double, double> Fitness {
			get;
			set;
		}
		public Chromosome Chromosome {
			get;
			set;
		}

		public Individual (int chromosomeLength, Random random)
		{
			Chromosome = new Chromosome(chromosomeLength, random);
		}
	}
}

