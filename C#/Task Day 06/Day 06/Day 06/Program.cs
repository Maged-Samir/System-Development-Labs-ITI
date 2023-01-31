namespace Day_06
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Test Questions && Answers

            Answer[] answer1 = new Answer[]
            {
                new Answer(1,"Maged"),
                new Answer(2,"Mohamed"),
                new Answer(3,"Ahmed"),
                new Answer(4,"Samy"),
            };

            Answer[] answer2 = new Answer[]
            {
                new Answer(1,"Red"),
                new Answer(2,"Green"),
                new Answer(3,"Blue"),
            };

            Answer[] answer3 = new Answer[]
            {
                new Answer(1,"True"),
                new Answer(2,"False"),

            };

            Answer[] answer4 = new Answer[]
            {
                new Answer(1,"Cairo"),
                new Answer(2,"Menofia"),

            };

            //Question[] questions = new Msq[] {
            //    new Msq(1, "what your name?", 20, answer1,new Answer(1,"Maged")) ,
            //    new Msq(2, "what your favourate Color?", 30, answer2,new Answer(3,"Blue")),
            //};

            //Question[] questions1 = new TrueOrFalse[]
            //{
            //    new TrueOrFalse(3,"Are u Single?",10,answer3,new Answer(1,"True")),
            //};


            Question[] questions2 = new Question[]
            {
                new Msq(1, "what your name?", 20, answer1,new Answer(1,"Maged")) ,
                new Msq(2, "what your favourate Color?", 30, answer2,new Answer(3,"Blue")),
                new TrueOrFalse(3,"Are u Single?",10,answer3,new Answer(1,"True")),
                new MultiMCQ(4,"Where do you Live?",20,answer4,new Answer(1,"Cairo&Menofia"))
            };

            


            //Test Final Exam
            Exam[] exam1 = new FinalExam[]
            {
                         new FinalExam(1,DateTime.Now,questions2)
            };

            //         for (int i = 0; i < exam1.Length; i++)
            //         {
            //             exam1[i].show();
            //         }


            

            //Test practice Exam
            Exam[] exam2 = new PracticeExam[]
            {
                new PracticeExam(2,DateTime.Now,questions2)
            };

            //for (int i = 0; i < exam2.Length; i++)
            //{
            //    exam2[i].show();
            //}


            
            Console.WriteLine(" PLZ Enter Your Exam Type :- \n Final Exam Press   ----> 1 \n Practice Exam Press ---> 2");
         
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        for (int i = 0; i < exam1.Length; i++)
                        {
                            exam1[i].show();
                        }
                        break;
                    case 2:
                        for (int i = 0; i < exam2.Length; i++)
                        {
                            exam2[i].show();
                        }
                        break;
                    default:
                        Console.WriteLine("You Have Entered Wrong Choise ");
                        break;
                }
            


        }
    }
}