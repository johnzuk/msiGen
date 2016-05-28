using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public interface ICrossoverOperator
	{
		void Crossover(Chromosome parent1, Chromosome parent2);
	}
}

