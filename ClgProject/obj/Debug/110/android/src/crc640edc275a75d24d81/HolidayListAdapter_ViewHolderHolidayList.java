package crc640edc275a75d24d81;


public class HolidayListAdapter_ViewHolderHolidayList
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ClgProject.HolidayListAdapter+ViewHolderHolidayList, ClgProject", HolidayListAdapter_ViewHolderHolidayList.class, __md_methods);
	}


	public HolidayListAdapter_ViewHolderHolidayList (android.view.View p0)
	{
		super (p0);
		if (getClass () == HolidayListAdapter_ViewHolderHolidayList.class)
			mono.android.TypeManager.Activate ("ClgProject.HolidayListAdapter+ViewHolderHolidayList, ClgProject", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
