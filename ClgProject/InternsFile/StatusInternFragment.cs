using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Fragment = AndroidX.Fragment.App.Fragment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.RecyclerView.Widget;
using ClgProject.InternsFile;
using ClgProject.InternsFile.Model;

namespace ClgProject
{
    public class StatusInternFragment : Fragment
    {
       
        private RecyclerView _recyclerViewLeaveStatus;
        private RecyclerView.LayoutManager _leaveStatusLayoutManager;
        private List<InternLeaveReason> _leaveList;
        private LeaveStatusListAdapter _leaveStatusAdapter;

       

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View leaveStatusView = inflater.Inflate(Resource.Layout.statusInternsFragment, container, false);
           _recyclerViewLeaveStatus = leaveStatusView.FindViewById<RecyclerView>(Resource.Id.recyclerViewLeaveStatusInterns);

            DataInput();

           _leaveStatusLayoutManager = new LinearLayoutManager(Activity);
           _recyclerViewLeaveStatus.SetLayoutManager(_leaveStatusLayoutManager);

            _leaveStatusAdapter = new LeaveStatusListAdapter(_leaveList, Activity);
            _recyclerViewLeaveStatus.SetAdapter(_leaveStatusAdapter);

            return leaveStatusView;
        }

        private void DataInput()
        {
            _leaveList = new List<InternLeaveReason>
            {
               new InternLeaveReason{ reason ="I have to visit a family function",date="Thu, 17 Mar",typeofleave="Half day",seperatordate =" March 2022",statusofleave="Accepted",buttontext="Req. to revoke"},
               new InternLeaveReason{ reason ="I am not feeling well..",date="Thu, 16 March",typeofleave="half day",seperatordate ="",statusofleave="Accepted",buttontext="Req. to revoke"},
               new InternLeaveReason{ reason ="I have to visit a dentist ",date="Mon, 14 March",typeofleave="Full day",seperatordate ="",statusofleave="Pending",buttontext="Revoke"},
                new InternLeaveReason{ reason ="Going to vacation with friends",date="Fri, 18 Feb",typeofleave="Full day . 4 day(s)",seperatordate =" Febuary 2022",statusofleave="Rejected",buttontext="Revoke"},
               new InternLeaveReason{ reason ="I have to visit marriage function..",date="Thu, 10 Feb",typeofleave="Half day",seperatordate ="",statusofleave="Accepted",buttontext="Req. to revoke"},
               new InternLeaveReason{ reason ="Going to vacation with family",date="Tue, 01 Feb ",typeofleave="Full day . 2 day(s)",seperatordate ="",statusofleave="Accepted",buttontext="Req. to revoke"},
               new InternLeaveReason{ reason ="I am not feeling well..",date="Mon, 17 Jan",typeofleave="Half day",seperatordate =" January 2022",statusofleave="Pending",buttontext="Revoke"},
               new InternLeaveReason{ reason ="There is a function at my home",date="Fri, 7 Jan",typeofleave="Full day",seperatordate ="",statusofleave="Rejected",buttontext="Revoke"},

            };
        }
    }
}