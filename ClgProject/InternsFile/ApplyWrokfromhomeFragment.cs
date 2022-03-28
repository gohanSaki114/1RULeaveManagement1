using Fragment = AndroidX.Fragment.App.Fragment;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClgProject.InternsFile
{
    public class ApplyWrokfromhomeFragment : Fragment
    {

        private TextView _textViewFromWfh, _textViewToWfh;
        private ImageView _imageViewFromWfh, _imageViewToWfh;
        private DateFromPickerDialogFragment _dateFromPickerDialoguefragment;
        private DateToPickerDialogFragment _dateToPickerDialoguefragment;
        private readonly string _tag = "Main Activity";
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View viewApplyWfh = inflater.Inflate(Resource.Layout.workFromHomeInternLayout, container, false);
            _imageViewFromWfh = viewApplyWfh.FindViewById<ImageView>(Resource.Id.imageViewFromCalender);
            _textViewFromWfh = viewApplyWfh.FindViewById<TextView>(Resource.Id.textViewShowDateFrom);

            _imageViewToWfh = viewApplyWfh.FindViewById<ImageView>(Resource.Id.imageViewToCalender);
            _textViewToWfh = viewApplyWfh.FindViewById<TextView>(Resource.Id.textViewShowDateTo);

            ObjectCreation();
            BindEventofDateChange();

            _imageViewFromWfh.Click += _imageViewFromWfh_Click;
            _imageViewToWfh.Click += _imageViewToWfh_Click;


            return viewApplyWfh;
        }

     
        private void ObjectCreation()
        {
            _dateFromPickerDialoguefragment = new DateFromPickerDialogFragment();
            _dateToPickerDialoguefragment = new DateToPickerDialogFragment();
        }

        private void BindEventofDateChange()
        {
            _dateFromPickerDialoguefragment.OnDateChangeHandlerFrom += _dateFromPickerDialoguefragment_OnDateChangeHandlerFrom;
            _dateToPickerDialoguefragment.OnDateChangeHandlerTo += _dateToPickerDialoguefragment_OnDateChangeHandlerTo;
        }


        private void _imageViewFromWfh_Click(object sender, EventArgs e)
        {
            _dateFromPickerDialoguefragment.Show(Activity.SupportFragmentManager, _tag);
        }
        private void _imageViewToWfh_Click(object sender, EventArgs e)
        {
            _dateToPickerDialoguefragment.Show(Activity.SupportFragmentManager, _tag);
        }

        private void _dateFromPickerDialoguefragment_OnDateChangeHandlerFrom(object sender, DateTime e)
        {
            _textViewFromWfh.Text = e.ToString("dd/MM/yyyy");
        }


        private void _dateToPickerDialoguefragment_OnDateChangeHandlerTo(object sender, DateTime e)
        {
            _textViewToWfh.Text = e.ToString("dd/MM/yyyy");
        }


    }
}