using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    enum State
    {
        UnderGratuated=0,Master=2,Phd=4,
    }
    internal abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int Id,string Name)
        {
             this.Id = Id;
             this.Name = Name;
        }

        public override string ToString() 
        {
            return $"{Id}-{Name}";
        }
    }

    internal class UnderGratuatedStudent : Student
    {
        public State Status { get; set; }
        public UnderGratuatedStudent(int Id, string Name, State status) : base(Id, Name)
        {
            Status = status;
        }

        public override string ToString()
        {
            return base.ToString()+ $"\t {Status} Student";
        }
    }

    internal class MasterStudent : Student
    {
        public State Status { get; set; }
        public MasterStudent(int Id, string Name, State status) : base(Id, Name)
        {
            Status = status;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t {Status} Student";
        }
    }

    internal class PhdStudent : Student
    {
        public State Status { get; set; }
        public PhdStudent(int Id, string Name, State status) : base(Id, Name)
        {
            Status = status;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t {Status} Student";
        }
    }

}
