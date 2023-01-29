﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Subject
    {
        //Dynamic Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        int grade; //Member Variable
        public int Grade  //Properity (Setter & Getter)
        {
            set
            {
                if(value > 0 && value<300)
                    grade= value;
            }
            get 
            {
                return grade;
            }
            
        }

        //Constructor Overloading
        public Subject()
        { }

        public Subject(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Subject(int Id,string Name, int duration) : this(Id, Name)
        {
            Duration = duration;
        }

        public Subject(int Id,string Name,int Duration, int Grade) :this(Id,Name,Duration)
        {
            this.grade = Grade;
        }

        public override string ToString()
        {
            return $" {Id}-{Name} \t {Duration} h - {Grade} mark";
        }


    }
}
