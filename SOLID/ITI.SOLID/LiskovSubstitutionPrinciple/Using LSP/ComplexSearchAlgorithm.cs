using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Using_LSP
{
    public class ComplexSearchAlgorithm
    {
        private SortingAlgorithm _sortingAlgorithm;

        public ComplexSearchAlgorithm(SortingAlgorithm sortingAlgorithm)
        {
            _sortingAlgorithm = sortingAlgorithm;
        }

        public void PerformSearch()
        {
            // Complex search algorithm implementation

            _sortingAlgorithm.Sort();

            // Continue with the search algorithm
        }
    }
}
