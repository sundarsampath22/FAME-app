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

namespace MessageCenter
{
    class Message
    {
        public string Content;
        public string Senter;
        public string Time;
        public Message(string content,string senter, string time)
        {
            Content = content;
            Senter = senter;
            Time = time;
        }
        public override string ToString()
        {
            return Content+" "+" from "+Senter+" "+Time;
        }
     
    }
}