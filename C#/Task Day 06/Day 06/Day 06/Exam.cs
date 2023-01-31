using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_06
{
    internal class Exam
    {
        public int id { get; set; }
        public DateTime date { get; set; }

        public Question[] questions { get; set; }

        public Exam()
        {

        }

        public Exam(int id, DateTime date, Question[]questions)
        {
            this.id = id;
            this.date = date;
            this.questions = questions;
        }

        public virtual void show()
        {
            Console.WriteLine($" Exam ID:{id} - {date} ");
        }
    }

    class FinalExam:Exam
    {
        public FinalExam(int id,DateTime date, Question[]questions) :base (id,date,questions)
        {
            
        }

        

        public override void show()
        {
            base.show();
            for (int i = 0; i < questions.Length; i++)
            {
                Console.Write($"\t {questions[i].id}-{questions[i].body}\t{questions[i].mark} mark\n");
                for (int j = 0; j < questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($" {questions[i].Answers[j].id}-{questions[i].Answers[j].Content}");
                }
            }
            Console.WriteLine("=====================");
            Console.WriteLine(" Right Answers Of Exam");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.Write($" {questions[i].id} - {questions[i].body} - {questions[i].modelAnswer.Content} \n");

            }
        }


    }

    class PracticeExam:Exam
    {
        public PracticeExam(int id, DateTime date, Question[] questions) : base(id, date, questions)
        {
        }


        public override void show()
        {
            base.show();
            for (int i = 0; i < questions.Length; i++)
            {
                Console.Write($"\t {questions[i].id}-{questions[i].body}\t{questions[i].mark} mark\n");
                for (int j = 0; j < questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($" {questions[i].Answers[j].id}-{questions[i].Answers[j].Content}");
                }
            }
            Console.WriteLine("=====================");

            Console.WriteLine(" PLZ Enter Your Answers:-");
            Answer[] StudentAnswer = new Answer[4];

            for (int i = 0; i < StudentAnswer.Length; i++)
            {
                StudentAnswer[i] = new Answer();
                Console.Write($" Ans Of Ques No {i + 1}:  ");
                StudentAnswer[i].Content = Console.ReadLine();
            }


            int Degree=0, FullMark = 0;
            Console.WriteLine("========================");
            Console.WriteLine(" Your Results");
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i].modelAnswer.Content == StudentAnswer[i].Content)
                {
                    Console.WriteLine("true");
                    Degree += questions[i].mark;
                }
                else
                {
                    Console.WriteLine("false");
                }
                FullMark+= questions[i].mark;

            }
            Console.WriteLine($" Your Degree In Exam : {Degree}/{FullMark}");


        }

    }

}
