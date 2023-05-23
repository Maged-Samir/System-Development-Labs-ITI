using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Original_Class
{
    public class ComplexSearchAlgorithm
    {
        private BubbleSort _bubbleSort;

        public ComplexSearchAlgorithm(BubbleSort bubbleSort)
        {
            _bubbleSort = bubbleSort;
        }

        public void PerformSearch()
        {
            // Complex search algorithm implementation

            _bubbleSort.Sort();

            // Continue with the search algorithm
        }
    }
}
