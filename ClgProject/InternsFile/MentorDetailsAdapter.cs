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

namespace ClgProject.InternsFile
{
    class MentorDetailsAdapter : RecyclerView.Adapter
    {
        private string[] names;

        public MentorDetailsAdapter(string[] names)
        {
            this.names = names;
        }

        public override int ItemCount => names.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MentorDetailsViewHolder mentorDetailsViewHolder = holder as MentorDetailsViewHolder;
            mentorDetailsViewHolder.BindData(names[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View mentordetails = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.mentorDetailListLayout, parent, false);
            return new MentorDetailsViewHolder(mentordetails);
        }
        class MentorDetailsViewHolder : RecyclerView.ViewHolder
        {
            private TextView _textViewMentorDetails;
            public MentorDetailsViewHolder(View itemView) : base(itemView)
            {
                _textViewMentorDetails = itemView.FindViewById<TextView>(Resource.Id.textViewMentorName);
            }

            internal void BindData(string v)
            {
                _textViewMentorDetails.Text = v;
            }
        }
    }
}