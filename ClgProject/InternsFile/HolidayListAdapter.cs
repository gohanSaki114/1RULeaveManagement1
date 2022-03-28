using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClgProject
{
    class HolidayListAdapter : RecyclerView.Adapter
    {
        private HolidayList holidaylist;
        private Context context;

        public HolidayListAdapter(HolidayList holidaylist, Context context)
        {
            this.holidaylist = holidaylist;
            this.context = context;
        }

        public override int ItemCount => holidaylist.holidayNumber;

        [Obsolete]
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolderHolidayList _holidayListHolder = holder as ViewHolderHolidayList;
            _holidayListHolder.BindData(holidaylist[position]);
            _holidayListHolder._holidaydateTextView.SetBackgroundResource(holidaylist[position].backgroundcolor);
            if (position % 2 != 0)
            {
                _holidayListHolder._holidaydateTextView.SetTextColor(context.Resources.GetColor(Resource.Color.orange));
            }
            else
            {

                
                _holidayListHolder._holidaydateTextView.SetTextColor(context.Resources.GetColor(Resource.Color.green));
            }
        }
       
        

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.listOfHolidayLayout, parent, false);
            return new ViewHolderHolidayList(v);
        }

        class ViewHolderHolidayList : RecyclerView.ViewHolder
        {
            public TextView _holidayTextView;
            public TextView _holidaydateTextView;
            public ViewHolderHolidayList(View itemView) : base(itemView)
            {
                _holidayTextView = itemView.FindViewById<TextView>(Resource.Id.textViewHolidays);
                _holidaydateTextView = itemView.FindViewById<TextView>(Resource.Id.texViewHolidayDate);
            }

            internal void BindData(Holiday holiday)
            {
                _holidayTextView.Text = holiday.holidayName;
                _holidaydateTextView.Text = holiday.holidayDate;
            }
        }
    }

}