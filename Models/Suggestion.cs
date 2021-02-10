using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieSite.Models
{
    public class Suggestion
    {
        //name of person who made suggestion
        public string name { get; set; }
        //name of suggested restaurant
        public string sName { get; set; }
        //person's favorite dish at restaurant
        public string sFavDish { get; set; }
        //phone number needs to be in correct format
        public string sPhone { get; set; }

    }
}
