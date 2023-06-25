//using ITI.Revision.DesignPatterns.Observer_DP;
//using ITI.Revision.DesignPatterns.Decorator_DP;
using ITI.Revision.DesignPatterns.Adapter_DP;
using System.Collections;
//using ITI.Revision.DesignPatterns.Strategy_DP;

namespace ITI.Revision.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Behavioral
            #region Strategy DP
            //IGoalStrategy goalByPenality = new GoalStrategyByPenality();
            //IGoalStrategy goalByHead = new GoalStrategyByHead();


            //Player p = new Player(goalByPenality,"Ahmed");


            //p.SetGoalStrategy(goalByHead);

            //p.DisplayPlayerStatus(); 
            #endregion

            #region Observer DP
            //Player player = new Player();
            //Refree refree = new Refree();

            //Ball ball = new Ball();

            //ball.AttachObserver(player);
            //ball.AttachObserver(refree);

            ////ball.DisplayObservers();
            //ball.Kick(); // event Fire  
            #endregion


            //Structural

            #region Decorator DP
            //Player P1 = new Definder();
            //Player P2 = new Definder();
            //Player P3 = new Definder();

            //P1.Play();
            //P2.Play();
            //P3.Play();

            //Console.WriteLine("-----------------------------");

            //P3 = new GoalKeeper(P3);
            //P3.Play(); 
            #endregion

            #region Adapter DP
            //Person p = new Person() { Id = 10, FirstName = "Leo", LastName = "Messi"};

            //PersonAdapter adapter = new PersonAdapter(p);

            //Player.DisplayDetails(adapter); //before using adapter we cant do that  
            #endregion


        }
    }
}