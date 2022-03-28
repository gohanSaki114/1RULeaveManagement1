
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using MikePhil.Charting.Charts;
using MikePhil.Charting.Components;
using MikePhil.Charting.Data;
using MikePhil.Charting.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace ClgProject
{


    class DashboardInternsFragment : Fragment
    {
        private PieChart _pieChartLeaveStatus;
        private PieDataSet _pieLaveStatusSetData;
        private PieData _pieDataLaveStatus;
        private List<PieEntry> _leaveStatus;
        private List<int> _piecolors;
        private RecyclerView _recyclerViewHolidayList;
        private RecyclerView.LayoutManager _layoutmanager;
        private HolidayListAdapter _holidayListAdapter;
        private HolidayList _holidaylist;
       

       

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.dashboardInternsFragmentLayout, container, false);
            _recyclerViewHolidayList = view.FindViewById<RecyclerView>(Resource.Id.recyclerViewHolidayList);
            _pieChartLeaveStatus = view.FindViewById<PieChart>(Resource.Id.pieChartLeaveStatus);
            
            _recyclerViewHolidayList.AddItemDecoration(new DividerItemDecoration(Activity.ApplicationContext, DividerItemDecoration.Vertical));
            
            _layoutmanager = new LinearLayoutManager(Activity);
            _recyclerViewHolidayList.SetLayoutManager(_layoutmanager);
            _holidaylist = new HolidayList();

            _holidayListAdapter = new HolidayListAdapter(_holidaylist, Activity);
            _recyclerViewHolidayList.SetAdapter(_holidayListAdapter);

            GetPieEntry();
           
            return view;

          
        }

        private void GetPieEntry()
        {

            _leaveStatus = new List<PieEntry>();
            _leaveStatus.Add(new PieEntry(8));
            _leaveStatus.Add(new PieEntry(1));
            _leaveStatus.Add(new PieEntry(5));


          


            _pieLaveStatusSetData = new PieDataSet(_leaveStatus,"Total Leaves");
            _piecolors = new List<int>();
            foreach (var color in ColorTemplate.MaterialColors)
            {
                _piecolors.Add(color);
            }

           _pieLaveStatusSetData.SetColors(_piecolors.ToArray());
            
            
            _pieDataLaveStatus = new PieData(_pieLaveStatusSetData);


            
            _pieChartLeaveStatus.Data = _pieDataLaveStatus;



            _pieChartLeaveStatus.SetDrawCenterText(true);
            _pieChartLeaveStatus.CenterText = "14";
            _pieChartLeaveStatus.Invalidate();
            _pieChartLeaveStatus.Description.Enabled = false;
            _pieChartLeaveStatus.Animate();
          
        }
    }
}