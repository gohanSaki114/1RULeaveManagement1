using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Felipecsl.GifImageViewLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClgProject.InternsFile
{
    public class LoginSuccessfullFragment : DialogFragment
    {
        public ImageView _myImageClose;
        public GifImageView _myGIFImage;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View viewLoginSuccessfull = inflater.Inflate(Resource.Layout.loginSuccessfullFragmentLayout, container, false);

            _myGIFImage = viewLoginSuccessfull.FindViewById<GifImageView>(Resource.Id.gifImageView);
            _myImageClose = viewLoginSuccessfull.FindViewById<ImageView>(Resource.Id.closeImageView);


            _myImageClose.Click += _myImageClose_Click;

            Stream input = Resources.OpenRawResource(Resource.Drawable.successfully);
            byte[] bytes = ConvertByteArray(input);
            _myGIFImage.SetBytes(bytes);
            _myGIFImage.StartAnimation();

            

            return viewLoginSuccessfull;
        }

        private void _myImageClose_Click(object sender, EventArgs e)
        {
            this.Dismiss();
        }

        private byte[] ConvertByteArray(Stream input)
        {

            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);
                return ms.ToArray();
            }
        }
    }
}