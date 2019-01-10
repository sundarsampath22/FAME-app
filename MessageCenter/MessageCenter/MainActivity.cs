using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace MessageCenter
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

    public class MainActivity : AppCompatActivity
    {
        
        private List<Message> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<Message>//need to receive from a DataBase instead
            {
                new Message( "How's your day?","lore","Yesterday at 3 pm" ),
                new Message( "How's your day?","Mike","Yesterday at 3 pm" ),
                new Message( "How's your day?","Micky","Yesterday at 3 pm" ),
                new Message( "How's your day?","kelly","Yesterday at 3 pm" )

            };
            

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].ToString());
            Toast.MakeText(this, mItems[e.Position].ToString(), ToastLength.Long).Show();
        }
    }
}