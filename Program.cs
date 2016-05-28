using System;
using System.Linq;
using System.Collections.Generic;

namespace msiGen
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Chromosome parent1 = new Chromosome(10, new Random());
			//Chromosome parent2 = new Chromosome(10, new Random());

			Mutation mutation = new Mutation(0.1);

			PrintChromosome(parent1);
			mutation.Mutate(parent1);
			PrintChromosome(parent1);
		}

		public static void PrintChromosome(Chromosome chromosome)
		{
			Console.WriteLine ("Chromosom ");
			foreach (var item in chromosome.Genes) {
				Console.Write(Convert.ToInt16(item));
			}
			Console.WriteLine ();
		}
	}
}
