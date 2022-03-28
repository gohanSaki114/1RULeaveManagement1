using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using ClgProject.InternsFile;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.FloatingActionButton;
using System;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;
using Fragment = AndroidX.Fragment.App.Fragment;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace ClgProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class DashboardInterns : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private BottomNavigationView _bottomNavigationViewInterns;
        private DashboardInternsFragment _dasboardInternsFragment;
        private StatusInternFragment _statusInternFragment;
        private ProfileInternFragment _profileInternFragment;
        private Toolbar _toolbar;
        private FloatingActionButton _buttonApplyLeave;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.dashboardInternsLayout);

            UIReferences();

            UIClickEvents();
            ObjectCreations();

            SetSupportActionBar(_toolbar);
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _dasboardInternsFragment).Commit();
            _toolbar.Title = Resources.GetString(Resource.String.dashboard);
        }

        private void UIReferences()
        {
            _bottomNavigationViewInterns = FindViewById<BottomNavigationView>(Resource.Id.bottonNavigationViewInterns);
            _buttonApplyLeave = FindViewById<FloatingActionButton>(Resource.Id.floatingActionButtonApplyLeave);
            _toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
        }
        
        private void UIClickEvents()
        {
            _bottomNavigationViewInterns.SetOnNavigationItemSelectedListener(this);
            _buttonApplyLeave.Click += _buttonApplyLeave_Click;
        }

        private void _buttonApplyLeave_Click(object sender, EventArgs e)
        {
            Intent applyLeaveIntent = new Intent(this, typeof(ApplyLeaveInternActivity));
            StartActivity(applyLeaveIntent);
        }

        private void ObjectCreations()
        {
            _dasboardInternsFragment = new DashboardInternsFragment();
            _statusInternFragment = new StatusInternFragment();
            _profileInternFragment = new ProfileInternFragment();
        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            
            switch (item.ItemId)
            {
                case Resource.Id.dashboard:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _dasboardInternsFragment).Commit();
                    _toolbar.Title = Resources.GetString(Resource.String.dashboard);
                    _buttonApplyLeave.Visibility = ViewStates.Visible;
                    break;

                case Resource.Id.status:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _statusInternFragment).Commit();
                    _toolbar.Title = Resources.GetString(Resource.String.leaveStatus);
                    _buttonApplyLeave.Visibility = ViewStates.Gone;
                    break;

                case Resource.Id.profile:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutDashBoard, _profileInternFragment).Commit();
                    _toolbar.Title = Resources.GetString(Resource.String.profile);
                    _buttonApplyLeave.Visibility = ViewStates.Gone;
                    break;


            }

          

            return true;
        }
    }
}