using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject[] arrOfSubjects { get; set; }

        //Ctor
        public Track(int Id,string Name, Subject[]arrOfSubjects)
        {
            this.Id = Id;
            this.Name = Name;
            this.arrOfSubjects = arrOfSubjects;
        }

        public override string ToString()
        {
            string txt = $" {Id} - {Name} \n";
            for(int i=0;i<arrOfSubjects.Length;i++) 
            {
                txt += arrOfSubjects[i].ToString() +"\n";
            }
            return txt ;
        }
    }
}
