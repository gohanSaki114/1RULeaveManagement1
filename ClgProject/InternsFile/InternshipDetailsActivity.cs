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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class InternshipDetailsActivity : Activity
    {
        public RecyclerView _recyclerViewmentorDetails;
        private  MentorDetailsAdapter _mentorDetailsAdapter;
        public ImageView _imageViewBack;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.internshipDetailsLayout);

            _recyclerViewmentorDetails = FindViewById<RecyclerView>(Resource.Id.recycleViewMentorDetails);
            _imageViewBack = FindViewById<ImageView>(Resource.Id.imageViewBack);

            string[] names = new string[] { "Shivam Mistry", "Daniel Richard", "Sam Paul", "Will Smith", "Shivam Mistry", "Mit", "Raju", "sagar" };

            _mentorDetailsAdapter = new MentorDetailsAdapter(names);
            _recyclerViewmentorDetails.SetAdapter(_mentorDetailsAdapter);

            _imageViewBack.Click += _imageViewBack_Click;


        }

        private void _imageViewBack_Click(object sender, EventArgs e)
        {
                    Finish();
        }
    }
}