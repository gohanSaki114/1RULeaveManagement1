using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using ClgProject.InternsFile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlertDialog = AndroidX.AppCompat.App.AlertDialog;

namespace ClgProject.InternsFile
{

    class LeaveStatusListAdapter : RecyclerView.Adapter
    {
        private List<InternLeaveReason> leaveList;
        private AlertDialog.Builder _alertBuilderRevokeRequest;
        private RecyclerView.ViewHolder viewHolder;
        LeaveListViewHolder1 _leaveListViewholder1;
        LeaveListViewHolder2 _leaveListViewHolder2;
        private FragmentActivity activity;
        public const int USER = 0, IMAGE = 1;

        public LeaveStatusListAdapter(List<InternLeaveReason> leaveList, FragmentActivity activity)
        {
            this.leaveList = leaveList;
            this.activity = activity;
        }

        public override int ItemCount => leaveList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            switch (holder.ItemViewType)
            {
                case USER:
                    LeaveListViewHolder1    viewHolder1 = holder as LeaveListViewHolder1;
                    configureViewHolder1(viewHolder1, position);
                    viewHolder1._revokeButton.Click += _revokeButton_Click;
                    break;
                case IMAGE:
                    LeaveListViewHolder2 viewholder2 = holder as LeaveListViewHolder2;
                    configureViewHolder2(viewholder2, position);
                    viewholder2._revokeButton2.Click += _revokeButton2_Click;
                    break;
            }
        }

        private void _revokeButton_Click(object sender, EventArgs e)
        {
            _alertBuilderRevokeRequest = new AlertDialog.Builder(activity);
            _alertBuilderRevokeRequest.SetTitle(Resource.String.revokeRequest);
            _alertBuilderRevokeRequest.SetMessage(Resource.String.revokeQuestion);
            _alertBuilderRevokeRequest.SetPositiveButton(Resource.String.yes, (s, e) => { Toast.MakeText(activity, "Yes", ToastLength.Short).Show(); });
            _alertBuilderRevokeRequest.SetNegativeButton(Resource.String.no, (s, e) => { _alertBuilderRevokeRequest.Dispose(); });
            _alertBuilderRevokeRequest.Show();
        }

        private void _revokeButton2_Click(object sender, EventArgs e)
        {
            _alertBuilderRevokeRequest = new AlertDialog.Builder(activity);
            _alertBuilderRevokeRequest.SetTitle(Resource.String.revokeRequest);
            _alertBuilderRevokeRequest.SetMessage(Resource.String.revokeQuestion);
            _alertBuilderRevokeRequest.SetPositiveButton(Resource.String.yes, (s, e) => { Toast.MakeText(activity, "Yes", ToastLength.Short).Show(); });
            _alertBuilderRevokeRequest.SetNegativeButton(Resource.String.no, (s, e) => { _alertBuilderRevokeRequest.Dispose(); });
            _alertBuilderRevokeRequest.Show();

        }

       

        private void configureViewHolder2(LeaveListViewHolder2 viewholder2, int position)
        {
            if (leaveList[position].statusofleave.Trim() == "Pending")
            {

                viewholder2._leaveStatusButton2.SetTextColor(Android.Graphics.Color.ParseColor("#FFB800"));

                viewholder2._leaveStatusButton2.SetBackgroundResource(Resource.Drawable.shape_rect_yellow);
            }
            else if (leaveList[position].statusofleave.Trim() == "Accepted")
            {
                viewholder2._leaveStatusButton2.SetTextColor(Android.Graphics.Color.ParseColor("#257CFF"));
                viewholder2._leaveStatusButton2.SetBackgroundResource(Resource.Drawable.shape_rect_blue);
            }
            else if (leaveList[position].statusofleave.Trim() == "Rejected")
            {
                viewholder2._leaveStatusButton2.SetTextColor(Android.Graphics.Color.ParseColor("#F26A6A"));
                viewholder2._leaveStatusButton2.SetBackgroundResource(Resource.Drawable.shape_rect_red);

            }
            viewholder2._monthnameTextView.Text = leaveList[position].seperatordate;
            viewholder2._reasonTextView2.Text = leaveList[position].reason;
            viewholder2._dayDateTextview2.Text = leaveList[position].date;
            viewholder2._typeofleaveTextview2.Text = leaveList[position].typeofleave;
            viewholder2._leaveStatusButton2.Text = leaveList[position].statusofleave;
            viewholder2._revokeButton2.Text = leaveList[position].buttontext;
        }

        private void configureViewHolder1(LeaveListViewHolder1 viewHolder1, int position)
        {
            if (leaveList[position].statusofleave.Trim() == "Pending")
            {

                viewHolder1._leaveStatusButton.SetTextColor(Android.Graphics.Color.ParseColor("#FFB800"));
                viewHolder1._leaveStatusButton.SetBackgroundResource(Resource.Drawable.shape_rect_yellow);
            }
            else if (leaveList[position].statusofleave.Trim() == "Accepted")
            {
                viewHolder1._leaveStatusButton.SetTextColor(Android.Graphics.Color.ParseColor("#257CFF"));
                viewHolder1._leaveStatusButton.SetBackgroundResource(Resource.Drawable.shape_rect_blue);
            }
            else if (leaveList[position].statusofleave.Trim() == "Rejected")
            {
                viewHolder1._leaveStatusButton.SetTextColor(Android.Graphics.Color.ParseColor("#F26A6A"));
                viewHolder1._leaveStatusButton.SetBackgroundResource(Resource.Drawable.shape_rect_red);
            }

            viewHolder1._reasonTextView.Text = leaveList[position].reason;
            viewHolder1._dayDateTextview.Text = leaveList[position].date;
            viewHolder1._typeofleaveTextview.Text = leaveList[position].typeofleave;
            viewHolder1._leaveStatusButton.Text = leaveList[position].statusofleave;
            viewHolder1._revokeButton.Text = leaveList[position].buttontext;
        }

        public override int GetItemViewType(int position)
        {
            if (leaveList[position].seperatordate != "")
                return IMAGE;
            else
                return USER;

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            switch (viewType)
            {
                case USER:
                    View v1 = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.leaveStatusHetrogenousListLayout1, parent, false);
                    viewHolder = new LeaveListViewHolder1(v1);
                    break;
                case IMAGE:
                    View v2 = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.leaveStatusHetrogenousListLayout2, parent, false);
                    viewHolder = new LeaveListViewHolder2(v2);
                    break;
            }
            return viewHolder;
        }

        class LeaveListViewHolder1 : RecyclerView.ViewHolder
        {
            public Button _leaveStatusButton, _revokeButton;
            public TextView _reasonTextView, _dayDateTextview, _typeofleaveTextview;
            public LeaveListViewHolder1(View itemView) : base(itemView)
            {
                _reasonTextView = itemView.FindViewById<TextView>(Resource.Id.textViewLeaveReason);
                _dayDateTextview = itemView.FindViewById<TextView>(Resource.Id.textViewDate);
                _typeofleaveTextview = itemView.FindViewById<TextView>(Resource.Id.textViewLeaveDays);
                _leaveStatusButton = itemView.FindViewById<Button>(Resource.Id.appCompatButtonStatus);
                _revokeButton = itemView.FindViewById<Button>(Resource.Id.appCompatButtonRevoke);
            }
        }
        class LeaveListViewHolder2 : RecyclerView.ViewHolder
        {
            public Button _leaveStatusButton2, _revokeButton2;
            public TextView _reasonTextView2, _dayDateTextview2, _typeofleaveTextview2;
            public TextView _monthnameTextView;
            public LeaveListViewHolder2(View itemView) : base(itemView)
            {
                _monthnameTextView = itemView.FindViewById<TextView>(Resource.Id.textViewMonth);
                _reasonTextView2 = itemView.FindViewById<TextView>(Resource.Id.textViewLeaveReasonList2);
                _dayDateTextview2 = itemView.FindViewById<TextView>(Resource.Id.textViewDateList2);
                _typeofleaveTextview2 = itemView.FindViewById<TextView>(Resource.Id.textViewLeaveDaysList2);
                _leaveStatusButton2 = itemView.FindViewById<Button>(Resource.Id.appCompatButtonStatusList2);
                _revokeButton2 = itemView.FindViewById<Button>(Resource.Id.appCompatButtonRevokeList2);
            }
        }

      
    }
}