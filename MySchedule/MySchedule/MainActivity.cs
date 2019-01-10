using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
/*Made to display user's schedule,currently only displaying the up-coming ones*/
namespace MySchedule
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<Schedule> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mListView = FindViewById<ListView>(Resource.Id.MylistView);

            mItems = new List<Schedule>//need to receive from a DataBase instead
            {
                new Schedule("Math xxx with Mr.Patrick in room 1 ","3 pm Monday" ),
                new Schedule("Chemistry xxx with Mrs.Dianain in room 2 ","2 pm Monday" ),
                new Schedule("Meeting  with Mr.Mike in room 5 ","3 pm Friday" ),
                new Schedule("Group Meeting with Mr.patrick in room 2 ","5 pm Monday" )

            };


            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;
        }
        /* display the complete schedule information in a string when clicked*/
        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            Toast.MakeText(this, mItems[e.Position].ToString(), ToastLength.Long).Show();
        }
    }
}