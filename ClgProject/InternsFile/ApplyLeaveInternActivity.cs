using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace ClgProject.InternsFile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme",  ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class ApplyLeaveInternActivity : AppCompatActivity
    {
        public TabLayout _mytabLayout;
        public TextView _mytextView;
        public FrameLayout frameLayout;
        public ImageView _myImageViewApplyLeave;
        public Button _myApplyButton;
        private LoginSuccessfullFragment _loginSuccessfullFragment;
        private ApplyLeaveFragment _fragmentApplyLeave;
        private ApplyWrokfromhomeFragment _fragmentApplyWorkfromhome;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.applyLeaveLayout);

            UIReferences();
            UIEventClick();
            ObjectCreation();
            setTabName();

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutApplyLeave, _fragmentApplyLeave).Commit();
        }

        

        private void UIReferences()
        {
            _mytabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);
            _myApplyButton = FindViewById<Button>(Resource.Id.applyButton);
            _myImageViewApplyLeave = FindViewById<ImageView>(Resource.Id.imageViewBackApplyLeave);
        }
        private void UIEventClick()
        {
            _mytabLayout.TabSelected += _mytabLayout_TabSelected;
            _myApplyButton.Click += _myApplyButton_Click;
            _myImageViewApplyLeave.Click += _myImageViewApplyLeave_Click;
        }

        private void _myImageViewApplyLeave_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void _mytabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
        {
            Fragment _selected = null;
            switch (e.Tab.Position)
            {

                case 0:
                    _selected = _fragmentApplyLeave;
                    break;
                case 1:
                    _selected = _fragmentApplyWorkfromhome;
                    break;
           
            }

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayoutApplyLeave, _selected).Commit();
        }

        private void _myApplyButton_Click(object sender, EventArgs e)
        {
            _loginSuccessfullFragment = new LoginSuccessfullFragment();
            var frag = SupportFragmentManager.BeginTransaction();
            _loginSuccessfullFragment.Cancelable = false;
            _loginSuccessfullFragment.Show(frag, "loginFrag");

        }


        private void ObjectCreation()
        {
            _fragmentApplyLeave = new ApplyLeaveFragment();
            _fragmentApplyWorkfromhome = new ApplyWrokfromhomeFragment();
            
        }
        private void setTabName()
        {
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.leave));
            _mytabLayout.AddTab(_mytabLayout.NewTab().SetText(Resource.String.workFromHome));
        }
    }
}