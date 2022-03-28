package crc6482bd6b2d40628ba8;


public class MentorDetailsAdapter_MentorDetailsViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ClgProject.InternsFile.MentorDetailsAdapter+MentorDetailsViewHolder, ClgProject", MentorDetailsAdapter_MentorDetailsViewHolder.class, __md_methods);
	}


	public MentorDetailsAdapter_MentorDetailsViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == MentorDetailsAdapter_MentorDetailsViewHolder.class)
			mono.android.TypeManager.Activate ("ClgProject.InternsFile.MentorDetailsAdapter+MentorDetailsViewHolder, ClgProject", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
