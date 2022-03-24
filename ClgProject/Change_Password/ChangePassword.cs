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

namespace ClgProject
{
    [Activity(Label = "ChangePassword",MainLauncher = true)]
    public class ChangePassword : AppCompatActivity
    {

        private TextInputLayout oldPassInputLayout, newPassInputLayout, confirmPassInputLayout;
        private EditText oldPassEditText, confirmPassEditText, NewPassEditText;
        private TextView forgetPassword;
        private Button changePasswordBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.change_password);
            UIReferences();
            // Create your application here
        }

        private void UIReferences()
        {
            oldPassInputLayout = FindViewById<TextInputLayout>(Resource.Id.oldPassInputLayout);
            newPassInputLayout = FindViewById<TextInputLayout>(Resource.Id.newPassInputLayout);
            confirmPassInputLayout = FindViewById<TextInputLayout>(Resource.Id.confirmPassInputLayout);
            oldPassEditText = FindViewById<EditText>(Resource.Id.oldPassEditText);
            confirmPassEditText = FindViewById<EditText>(Resource.Id.confirmPassEditText);
            NewPassEditText = FindViewById<EditText>(Resource.Id.NewPassEditText);
            forgetPassword = FindViewById<TextView>(Resource.Id.Forgetpassword);
            changePasswordBtn = FindViewById<Button>(Resource.Id.changePasswordBtn);

        }


    }
}