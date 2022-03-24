using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.TextField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClgProject.Forget_Password
{
    [Activity(Label = "ForgetPassword")]
    public class ForgetPassword : AppCompatActivity
    {
        private TextInputLayout emailTextInputLayout;
        private EditText emailTextInputEditText;
        private Button submitButton;
        private TextView Resend;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.forget_password); 
            UIReferences();
 
                }

        private void UIReferences()
        {
            emailTextInputLayout = FindViewById<TextInputLayout>(Resource.Id.emailTextInputLayout1);
            emailTextInputEditText = FindViewById<EditText>(Resource.Id.emailTextInputEditText);
            submitButton = FindViewById<Button>(Resource.Id.submitButton);
            Resend = FindViewById<TextView>(Resource.Id.resendTextView); 
        }
    }
}