using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_07
{
   


    internal class Question
    {
        public int id { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public Answer[] Answers { get; set; }

        public Answer modelAnswer { get; set; }

        public Question()
        {

        }
       
        public Question(int id, string body, int mark, Answer[] answers, Answer modelAnswer)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;
            Answers = answers;
            this.modelAnswer = modelAnswer;
        }

        public virtual void show()
        {
            Console.WriteLine($" {id} - {body}    Mark :{mark}");
        }




    }
    
    class Msq : Question
    {

        public Msq(int id, string body, int mark, Answer[] answers,Answer modelAnswer) : base(id, body, mark,answers,modelAnswer)
        {

        }

        public Msq()
        {
        }

        public override void show()
        {
            base.show();
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.Write($"   {Answers[i]}");

            }
            Console.WriteLine();
        }

       
    }


    class TrueOrFalse : Question
    {

        public TrueOrFalse(int id, string body, int mark, Answer[]answers,Answer modelAnswer) : base(id, body, mark,answers, modelAnswer)
        {
            
        }

        public override void show()
        {
            base.show();
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.Write($"   {Answers[i]}");
            }
            Console.WriteLine();

        }


        }


    class MultiMCQ : Question
    {


       

        public MultiMCQ(int id, string body, int mark, Answer[] answers, Answer modelAnswer) : base(id, body, mark, answers, modelAnswer)
        {
           
        }

        public override void show()
        {
            base.show();
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.Write($"   {Answers[i]}");

            }
            Console.WriteLine();

        }

    }

    class QuestionList : List<Question>
    {


        public new void Add(Question question)
        {
            base.Add(question);

        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is Question) return Equals((Question)obj);
            return base.Equals(obj);
        }

    }
}