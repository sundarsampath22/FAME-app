using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class schedule : ContentPage
    {
        public schedule()
        {
            InitializeComponent();
            Schedule schedule1 = new Schedule("Math Tutoring", "Today at 4pm");
            Schedule schedule2 = new Schedule("Physics Tutoring", "Today at 6pm");
            Schedule schedule3 = new Schedule("Chemistry Tutoring", "Tommrrow at 3pm");
            List<Schedule> mySchedules = new List<Schedule>();
            ListView scheduleListView = new ListView();
            {
                scheduleListView.ItemsSource = mySchedules;
                scheduleListView.ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label eventLabel = new Label();
                    eventLabel.SetBinding(Label.TextProperty, mySchedules[0].getEvent());

                    Label timeLabel = new Label();
                    timeLabel.SetBinding(Label.TextProperty,
                        new Binding(mySchedules[0].getTime(), BindingMode.OneWay,
                            null, null, null, null));



                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {

                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                           eventLabel,
                                            timeLabel
                                        }
                                        }
                                }
                        }
                    };
                });
               
            }
            
        }
        
           
        
    public class Schedule
    {
        string events;
        string time;
        public Schedule(string events, string time)
        {
            events = this.events;
            time = this.time;
        }
        public string getEvent()
        {
            return events;
        }
        public string getTime()
        {
            return time;
        }
        public override string ToString()
        {
            string eventDiscription = string.Format("You have {0} at {0} ", getEvent(), getTime());
            return eventDiscription;
        }
    }

    }

   
}
