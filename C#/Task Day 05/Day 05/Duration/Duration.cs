using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    public class Duration
    {
        public string Time { get; set; } 
        public int Houres { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        

        public Duration(int houres = 0, int minutes = 0, int seconds = 0)
        {
            Houres = houres;
            Minutes = minutes;
            Seconds = seconds;
        }


        public Duration(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            Time = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                                  t.Hours,
                                  t.Minutes,
                                  t.Seconds);
        }

        public override string ToString()
        {
            return $"Our Duration : ({Time})";
        }

        public string Print()
        {
           return $"Our Duration : ({Houres}h - {Minutes}m - {Seconds}s)";
        }

        public override bool Equals(object obj)
        {
            Duration p = (Duration)obj;
            return (p.Houres == Houres && p.Minutes == Minutes && p.Seconds == Seconds);
        }

       public static Duration operator+ (Duration d1, Duration d2)
        {
            return new Duration()
            {

                Seconds = d1.Seconds + d2.Seconds,
                Minutes = d1.Minutes + d2.Minutes,
                Houres = d1.Houres + d2.Houres,
                
            };
        }

        public static Duration operator+ (Duration d1,int m)
        {
            return new Duration((d1.ConvertToSeconds() + m * 60))
            {

            };
        }

        public static Duration operator +(int m, Duration d1)
        {
            return new Duration((d1.ConvertToSeconds() + m * 60))
            {

            };
        }

        private int ConvertToSeconds()
        {
            return Houres * 3600 + Minutes * 60 + Seconds;
        }

        public static bool operator >= (Duration d1, Duration d2)
        {
            if (d1 != null && d2 != null)
                return (d1.ConvertToSeconds() >= d2.ConvertToSeconds());
            return false;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1 != null && d2 != null)
                return (d1.ConvertToSeconds() <= d2.ConvertToSeconds());
            return false;
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if(d1 !=null && d2!= null)
                return(d1.ConvertToSeconds()>d2.ConvertToSeconds());
            return false;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1 != null && d2 != null)
                return (d1.ConvertToSeconds() < d2.ConvertToSeconds());
            return false;
        }

        public static Duration operator++(Duration d)
        {
            return new Duration()
            {

                Seconds = d.Seconds,
                Minutes = d.Minutes + 1,
                Houres = d.Houres

            };
        }

        public static Duration operator --(Duration d)
        {
            return new Duration()
            {

                Seconds = d.Seconds,
                Minutes = d.Minutes - 1,
                Houres = d.Houres

            };
        }

        public static implicit operator bool(Duration d)

        {
            if (d.Houres == 0 && d.Minutes == 0 && d.Seconds == 0)
                return false;
            return true;
        }


        public static implicit operator DateTime(Duration d)
        {
            DateTime TimeNow = DateTime.Now;
            return new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, d.Houres, d.Minutes, d.Seconds);
        }

        

    }
}
