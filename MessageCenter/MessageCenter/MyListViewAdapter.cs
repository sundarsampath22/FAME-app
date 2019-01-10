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
    class MyListViewAdapter : BaseAdapter<Message>
    {
        private List<Message> mItems;
        private readonly Context mContext;

        public MyListViewAdapter(Context context, List<Message> items)
        {
            mItems = items;
            mContext = context;
        }
        public override int Count
        {
            get { return mItems.Count; }
        }
        public override Message this[int position]
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

            if(row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listView_row, null, false); 
            }
            TextView txtContent = row.FindViewById<TextView>(Resource.Id.txtContent);
            txtContent.Text = mItems[position].Content;

            TextView txtSenter = row.FindViewById<TextView>(Resource.Id.txtSenter);
            txtSenter.Text = mItems[position].Senter;

            TextView txtTime = row.FindViewById<TextView>(Resource.Id.txtTime);
            txtTime.Text = mItems[position].Time;

            return row;
        }
    }
}