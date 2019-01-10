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

/*Customized ListViewAdapter, really simple and basic*/
namespace MySchedule
{
    class MyListViewAdapter : BaseAdapter<Schedule>
    {
        private List<Schedule> mItems;
        private readonly Context mContext;

        public MyListViewAdapter(Context context, List<Schedule> items)
        {
            mItems = items;
            mContext = context;
        }
        public override int Count
        {
            get { return mItems.Count; }
        }
        public override Schedule this[int position]
        {
            get { return mItems[position]; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listView_row, null, false);
            }
            TextView txtEvent = row.FindViewById<TextView>(Resource.Id.Event);
            txtEvent.Text = mItems[position].Event;

            TextView txtTime = row.FindViewById<TextView>(Resource.Id.txtTime);
            txtTime.Text = mItems[position].Time;

            return row;
        }
    }
}