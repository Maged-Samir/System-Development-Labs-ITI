using System.IO.Pipes;

namespace Day_07
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Test Questions && Answers

            List<Answer> answer1 = new List<Answer>()
            {
                new Answer(1, "Mona"),
                new Answer(2, "Mohamed"),
                new Answer(3, "Ahmed"),
                new Answer(4, "Samy")
            };

            

            List<Answer> answer2 = new List<Answer>()
            {
                new Answer(1,"Red"),
                new Answer(2,"Green"),
                new Answer(3,"Blue"),
            };

            List<Answer> answer3= new List<Answer>()
            {
                new Answer(1,"True"),
                new Answer(2,"False"),

            };

            List<Answer> answer4 = new List<Answer>()
            {
                new Answer(1,"Cairo"),
                new Answer(2,"Menofia"),

            };


            Dictionary<Question,List<Answer>> QuestionAnswers= new Dictionary<Question,List<Answer>>();

            QuestionAnswers.Add(new Msq(1, "what your name?", 20, answer1.ToArray(), new Answer(1, "Mona")), answer1);
            QuestionAnswers.Add(new Msq(2, "what your favourate Color?", 30, answer2.ToArray(), new Answer(3, "Blue")), answer2);
            QuestionAnswers.Add(new TrueOrFalse(3, "Are u Single?", 10, answer3.ToArray(), new Answer(1, "True")), answer3);
            QuestionAnswers.Add(new MultiMCQ(4, "Where do you Live?", 20, answer4.ToArray(), new Answer(1, "Cairo&Menofia")), answer4);


            

            //Test Final Exam
            Exam exam1 = new FinalExam(1, DateTime.Now, QuestionAnswers.Keys.ToArray());
            exam1.textFile();

            //Test practice Exam
            Exam exam2 = new PracticeExam(2, DateTime.Now, QuestionAnswers.Keys.ToArray());


            Console.WriteLine(" PLZ Enter Your Exam Type :- \n Final Exam Press   ----> 1 \n Practice Exam Press ---> 2");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                        exam1.show();
                    break;
                case 2:
                        exam2.show();
                    break;
                default:
                    Console.WriteLine("You Have Entered Wrong Choise ");
                    break;
            }


        }
    }
}