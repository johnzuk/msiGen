using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public class OnePointCrossover : ICrossoverOperator
	{
		public void Crossover(Chromosome parent1, Chromosome parent2)
		{
			Random rnd = new Random();
			int position = rnd.Next(1, parent1.Genes.Count);
			int elements = parent1.Genes.Count - position;

			var mixParent1 = 
				parent1.Genes.Skip(position).Take(elements).ToList();
			var mixParent2 = 
				parent2.Genes.Skip(position).Take(elements).ToList();

			parent1.Genes.RemoveRange(position, elements);
			parent1.Genes.AddRange(mixParent2);

			parent2.Genes.RemoveRange(position, elements);
			parent2.Genes.AddRange(mixParent1);
		}
	}
}

