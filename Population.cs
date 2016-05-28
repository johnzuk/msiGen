using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	public class Population
	{

		public List<Individual> Individuals {
			get;
			set;
		}

		private Func<double, double> _fitnessFunctions {
			get;
			set;
		}

		public Population (int numberOfIndividuals, int chromosomeLength,
			Func<double, double> fitnessFunction, Random random
		)
		{
			Individuals = Enumerable.Range(0, numberOfIndividuals)
				.Select(x => new Individual(chromosomeLength, random))
				.ToList();
			_fitnessFunctions = fitnessFunction;
		}

		public void UpdateFitness() {
			foreach (var item in Individuals) {
				item.Fitness = _fitnessFunctions;
			}
		}
	}
}
