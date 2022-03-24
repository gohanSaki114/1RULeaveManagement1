package crc64de9b17b706be5f03;


public class ForgetPassword
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ClgProject.Forget_Password.ForgetPassword, ClgProject", ForgetPassword.class, __md_methods);
	}


	public ForgetPassword ()
	{
		super ();
		if (getClass () == ForgetPassword.class)
			mono.android.TypeManager.Activate ("ClgProject.Forget_Password.ForgetPassword, ClgProject", "", this, new java.lang.Object[] {  });
	}


	public ForgetPassword (int p0)
	{
		super (p0);
		if (getClass () == ForgetPassword.class)
			mono.android.TypeManager.Activate ("ClgProject.Forget_Password.ForgetPassword, ClgProject", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
