using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using ClgProject.Forget_Password;
using Google.Android.Material.TextField;
using System;

namespace ClgProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        private TextInputLayout usernamelyt, passwordlyt;
        private EditText usernametxt, passwordtxt;
        private TextView forget;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login_page);
            UIReferences();
            UIClickEvent(); 
        }
     

        private void UIClickEvent()
        {
            forget.Click += Forget_Click;    
        }

        private void Forget_Click(object sender, EventArgs e)
        {
            Intent FP = new Intent(this, typeof(ForgetPassword));
            StartActivity(FP);
        }

        private void UIReferences()
        {
            usernamelyt = FindViewById<TextInputLayout>(Resource.Id.usernameInputLayout);
            passwordlyt = FindViewById<TextInputLayout>(Resource.Id.PasswordInputLayout);
            usernametxt = FindViewById<EditText>(Resource.Id.usernametxt);
            passwordtxt = FindViewById<EditText>(Resource.Id.Passwordtxt);
            forget = FindViewById<TextView>(Resource.Id.Forgetpasswordtxt);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
}