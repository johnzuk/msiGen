using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public class Mutation : IMutationOperator
	{
		private double _mutationProbability {
			get;
			set;
		}

		public Mutation (double mutationProbability = 0.1)
		{
			_mutationProbability = mutationProbability;
		}

		public void Mutate(Chromosome chromosome)
		{
			Random rnd = new Random();
			chromosome.Genes = chromosome.Genes.Select(
				n => rnd.NextDouble() <= _mutationProbability ? !n : n
			).ToList();
		}
	}
}

