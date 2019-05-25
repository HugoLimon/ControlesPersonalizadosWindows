using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    public class Time
    {
        public int hour { get; set; }
        public int minutes { get; set; }
        public Time(int _hora, int _minutos)
        {
            hour = _hora;
            minutes = _minutos;
        }


    }
}
