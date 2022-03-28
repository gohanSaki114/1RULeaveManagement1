using Fragment = AndroidX.Fragment.App.Fragment;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace ClgProject.InternsFile
{
    public class ApplyLeaveFragment : Fragment
    {
        private ImageView _imageViewFrom, _imageViewTo;
        private TextView _textViewFromDate, _textViewToDate;
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
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View viewApplyLeave = inflater.Inflate(Resource.Layout.leaveInternLayout, container, false);
            _imageViewFrom = viewApplyLeave.FindViewById<ImageView>(Resource.Id.imageViewFromCalender);
            _textViewFromDate = viewApplyLeave.FindViewById<TextView>(Resource.Id.textViewFromDate);

            _imageViewTo = viewApplyLeave.FindViewById<ImageView>(Resource.Id.imageViewToCalender);
            _textViewToDate = viewApplyLeave.FindViewById<TextView>(Resource.Id.textViewToDate);

            ObjectCreation();
            BindEventofDateChange();

            _imageViewFrom.Click += _imageViewFrom_Click;
            _imageViewTo.Click += _imageViewTo_Click;

            return viewApplyLeave;
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

        private void _dateFromPickerDialoguefragment_OnDateChangeHandlerFrom(object sender, DateTime e)
        {
            _textViewFromDate.Text = e.ToString(format: "dd/MM/yyyy");
        }

        private void _dateToPickerDialoguefragment_OnDateChangeHandlerTo(object sender, DateTime e)
        {
            _textViewToDate.Text = e.ToString(format: "dd/MM/yyyy");
        }

      

        private void _imageViewFrom_Click(object sender, System.EventArgs e)
        {
            _dateFromPickerDialoguefragment.Show(Activity.SupportFragmentManager,_tag);
        }

        private void _imageViewTo_Click(object sender, System.EventArgs e)
        {
            _dateToPickerDialoguefragment.Show(Activity.SupportFragmentManager, _tag);
        }

       
    }
}