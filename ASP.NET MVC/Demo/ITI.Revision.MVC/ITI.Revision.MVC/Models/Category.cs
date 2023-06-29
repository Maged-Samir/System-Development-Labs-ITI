namespace ITI.Revision.MVC.Models
{
   public enum ClassLevel
    {
        A,B,C,
    }

    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ClassLevel? ClassLevel { get; set; }

       


    }

    
}
