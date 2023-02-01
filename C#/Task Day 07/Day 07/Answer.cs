using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_07
{
    internal class Answer
    {

        public int id { get; set; }
        public string Content { get; set; }

        public Answer()
        {
        }

        public Answer(int id,string Content)
        {
            this.id = id;
            this.Content = Content;
        }

        public override string ToString()
        {
            return $"  {id} - {Content} ";
        }
    }

    class AnswerList:List<Answer>
    {

    }

}
