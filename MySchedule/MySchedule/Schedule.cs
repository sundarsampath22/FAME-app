using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MySchedule
{

    class Schedule
    {
        public string Event, Time;
        public Schedule(string eveNt, string time)
        {
            Event = eveNt;
            Time = time;
        }
        public override string ToString()
        {
            return Event + " at " +"   "+ Time;
        }
    }
}