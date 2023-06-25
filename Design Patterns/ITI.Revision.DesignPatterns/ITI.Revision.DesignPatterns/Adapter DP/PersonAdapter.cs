using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Adapter_DP
{
    internal class PersonAdapter : Player
    {
        Person person;
        public PersonAdapter(Person person)
        {
            this.person = person;
        }

        public int ID
        {
            get => person.Id;
            set => person.Id = value;
        }
        public string? FullName
        {
            get => $"{person.FirstName} {person.LastName}";
            set
            {
                if (value != null)
                {
                    string[] nameParts = value.Split(' ');
                    if (nameParts.Length == 2)
                    {
                        person.FirstName = nameParts[0];
                        person.LastName = nameParts[1];
                    }
                }
            }
           
        }
        
   
    }
}
