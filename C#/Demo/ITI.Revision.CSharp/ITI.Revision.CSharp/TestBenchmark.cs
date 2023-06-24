using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.CSharp
{
    public class TestBenchmark
    {
        [Benchmark]
        public string PrintPatternUsingString()
        {
            string Pattern = "*";
            string txt = string.Empty;
            for(int i = 0; i < 10; i++) 
            {
                 txt += Pattern;
            }
            return txt.ToString();
        }


        [Benchmark]
        public string PrintPatternUsingStringBuilder()
        {
            string Pattern = "*";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(Pattern);
            }
            return sb.ToString();
        }

    }
}
