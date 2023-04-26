using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class StaticContext
    {
        public static List<Track> Tracks { get; set; } = new List<Track>()
    {
        new Track { Id = 1, Name = "C# Programming", Description = "Learn how to program in C#" },
        new Track { Id = 2, Name = "Web Development", Description = "Learn how to build websites" },
        new Track { Id = 3, Name = "Data Science", Description = "Learn how to analyze data" }
    };

        public static List<Trainee> Trainees { get; set; } = new List<Trainee>()
    {
        new Trainee { Id = 1, Name = "Maged", Gender = "Male", Email = "maged@gmail.com", MobileNo = "012222222", Birthdate = new DateTime(1995, 1, 1), IsGraduated = true },
        new Trainee { Id = 2, Name = "Omnia", Gender = "Female", Email = "omnia@gmail.com", MobileNo = "011111111", Birthdate = new DateTime(1998, 5, 15), IsGraduated = false },
        new Trainee { Id = 3, Name = "Samy", Gender = "Male", Email = "samy@gmail.com", MobileNo = "0100000000", Birthdate = new DateTime(2000, 10, 1), IsGraduated = true }
    };


    }
}
