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

namespace ClgProject
{
    class Holiday
    {
        public Holiday(string holidays, string date, int background)
        {
            holidayName = holidays;
            holidayDate = date;
            backgroundcolor = background;
           
        }

        public string holidayName { get; set; }
        public string holidayDate { get; set; }
        public int backgroundcolor { get; set; }
    }
    class HolidayList
    {
        static Holiday[] holidayNameList =
        {

            new Holiday("Makar Sankranti","14 JAN",Resource.Drawable.shape_rect_green),
            new Holiday("Republic Day","26 JAN",Resource.Drawable.shape_rect_orange),
            new Holiday("MahaShiv Ratri", "1 MAR",Resource.Drawable.shape_rect_green),
            new Holiday("Dhuleti","18 MAR",Resource.Drawable.shape_rect_orange),
            new Holiday("Ambedkar Jayanti","14 APR",Resource.Drawable.shape_rect_green),
            new Holiday("Good Friday","15 APR",Resource.Drawable.shape_rect_orange),
            new Holiday("Raksha Bandhan","11 AUG",Resource.Drawable.shape_rect_green),
            new Holiday("Independence Day","15 AUG",Resource.Drawable.shape_rect_orange),
            new Holiday("Parsi New Year","16 AUG",Resource.Drawable.shape_rect_green),
            new Holiday("Janmastami","19 AUG",Resource.Drawable.shape_rect_orange),
            new Holiday("Ganesh Chaturthi","31 AUG",Resource.Drawable.shape_rect_green),
            new Holiday("Gandhi Jayanti","02 OCT",Resource.Drawable.shape_rect_orange),
            new Holiday("Dussehra", "05 OCT",Resource.Drawable.shape_rect_green),
            new Holiday("Diwali","24 OCT",Resource.Drawable.shape_rect_orange),
            new Holiday("Christmas Day","25 DEC",Resource.Drawable.shape_rect_green),

        };

        private Holiday[] myholidays;
        public HolidayList()
        {
            myholidays = holidayNameList;
        }

        public int holidayNumber
        { 
            get { return myholidays.Length; }
        }

        public Holiday this[int i]
        { 
        
            get { return myholidays[i]; }        
        }
    }
}