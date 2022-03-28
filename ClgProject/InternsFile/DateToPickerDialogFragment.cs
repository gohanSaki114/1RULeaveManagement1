using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClgProject.InternsFile
{
    class DateToPickerDialogFragment : AndroidX.Fragment.App.DialogFragment, DatePickerDialog.IOnDateSetListener
    {
        
            public event EventHandler<DateTime> OnDateChangeHandlerTo;
            public override Android.App.Dialog OnCreateDialog(Bundle savedInstanceState)
            {
                DateTime currentDT = DateTime.Now;
                DatePickerDialog datePicker = new DatePickerDialog(Activity, this, currentDT.Year, currentDT.Month - 1, currentDT.Day);
                return datePicker;
            }

            public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
            {
                DateTime dateTime = new DateTime(year, month + 1, dayOfMonth);
                OnDateChangeHandlerTo ?.Invoke(this, dateTime);

            }
    }
}
