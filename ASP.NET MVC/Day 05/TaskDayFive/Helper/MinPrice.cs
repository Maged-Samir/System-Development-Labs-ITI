using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskDayFive.Helper
{
    public class MinPrice:ValidationAttribute
    {
        int value;
        public MinPrice(int num)
        {
            value = num;
        }

        public override bool IsValid(object obj)
        {
            if(obj == null )
            {
                return false;
            }
            else
            {
                if(obj is int )
                {
                    int suppliedvalue = (int)obj;
                    if(suppliedvalue > value)
                    { 
                    return true;
                    }
                    else
                    {
                        ErrorMessage = " Minmum Value For Price Shoul be +" + value;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }


        }
    }
}