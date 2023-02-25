using Day14.Context;
using Day14.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14.BLL
{
    public class TitleManager
    {
        static pubsContext context = new();

        public static BindingList<Title> SelectAllTitlesWithBinding()
        {
            try
            {
                context.Titles.Load();
                return context.Titles.Local.ToBindingList();
            }
            catch
            {
                return new();
            }
        }

        public static bool Save()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                context = new();
                Trace.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
