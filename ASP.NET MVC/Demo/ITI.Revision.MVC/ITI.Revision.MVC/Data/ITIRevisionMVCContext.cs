using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITI.Revision.MVC.Models;

namespace ITI.Revision.MVC.Data
{
    public class ITIRevisionMVCContext //: DbContext
    {
        //public ITIRevisionMVCContext(DbContextOptions<ITIRevisionMVCContext> options)
        //    : base(options)
        //{
        //}

        //public DbSet<ITI.Revision.MVC.Models.Category> Category { get; set; } = default!;

        public static List<Category> Categories = new List<Category>()
    {
        new Category { Id = 1,Name="Mobile",ClassLevel= Models.ClassLevel.A},
        new Category { Id = 2,Name="Labtop",ClassLevel= Models.ClassLevel.B },
        new Category { Id = 3,Name="PC Screen",ClassLevel=Models.ClassLevel.C},
        new Category { Id = 4,Name="TV",ClassLevel=Models.ClassLevel.C },
        new Category { Id = 5,Name="Printer",ClassLevel=Models.ClassLevel.B}
    };

    }
}
