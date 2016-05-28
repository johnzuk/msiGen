using System;

namespace msiGen
{
	public interface IMutationOperator
	{
		void Mutate(Chromosome chromosome);
	}
}

