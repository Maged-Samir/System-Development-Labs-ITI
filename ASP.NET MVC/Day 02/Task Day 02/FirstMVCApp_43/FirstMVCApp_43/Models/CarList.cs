using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp_43.Models
{
    public class CarList
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car (){Id=1, Color="Red", Model="2020",Manfacture="Egypt",Img = "1.jpg"  },
            new Car (){Id=2, Color="Black", Model="2019",Manfacture="Algeria",Img = "1.jpg"  },
            new Car (){Id=3, Color="Orange", Model="2018",Manfacture="Germany",Img = "1.jpg"  },
            new Car (){Id=4, Color="White", Model="2022",Manfacture="France",Img = "1.jpg"  },

            };
    }
}