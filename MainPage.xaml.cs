using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        int count = 3;
        public MainPage()
        {

            InitializeComponent();
            DisplayAlert("Alert", string.Format("You have{0}", count), "OK");

            string[] messages = new string[10];
        }
        string[] replymessage = new string[10];
        void ShowMessages(string[] ms)
        {
            
        }
         void ClearMessages(object sender, EventArgs e)
        {

            DisplayAlert("Alert","You have 0 new messages",  "OK");

        }
        void replyMessage(object sender, EventArgs e)
        {
            
        }

         void DeleteMessage(object sender, EventArgs e)
        {
            
        }
        
    }
}
