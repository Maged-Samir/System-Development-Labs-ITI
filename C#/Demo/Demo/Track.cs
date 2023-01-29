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
            string txt = $"Track Information:- {Id} - {Name} \n";
            for(int i=0;i<arrOfSubjects.Length;i++) 
            {
                txt += arrOfSubjects[i].ToString() +"\n";
            }
            return txt ;
        }


        // ["101"]=C#
        //public string this[int id]
        //{
        //    set
        //    {
        //        for(int i=0;i< arrOfSubjects.Length;i++) 
        //        {
        //            if (arrOfSubjects[i].Id == id)
        //                arrOfSubjects[i].Name = value;
        //        }
        //    }
        //}


        public string this[int id]
        {
            get
            {
                for(int i=0;i<arrOfSubjects.Length;i++)
                {
                    if (arrOfSubjects[i].Id==id)
                        return $"Search Result Of Indexer :- {arrOfSubjects[i].Id}-{arrOfSubjects[i].Name}";
                }
                return $"Search Result Of Indexer :- Not Found";
            }
        }

    }
}
