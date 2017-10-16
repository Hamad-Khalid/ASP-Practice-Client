using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Program
    {
        public string Name;
        public string time;

        public string currentTimeSlot()
        {
            DateTime currently = new DateTime(2010,10,10,10,10,10);
            switch (currently.Hour){
                case 10 :
                    return "1";
                case 11 :
                    return "2";
                case 12 :
                    return "3";
                default :
                    return "closed";
            }
        } 
    }
}