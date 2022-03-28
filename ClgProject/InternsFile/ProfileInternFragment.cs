using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using DE.Hdodenhof.Circleimageview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fragment = AndroidX.Fragment.App.Fragment;
using AlertDialog = AndroidX.AppCompat.App.AlertDialog;
using Xamarin.Essentials;
using Android.Graphics;
using System.Threading.Tasks;
using Path = System.IO.Path;
using ClgProject.InternsFile;

namespace ClgProject
{
    public class ProfileInternFragment : Fragment

    {

        public ImageView _imageViewInternshipDetails, _imageViewChangePassword;
        public CircleImageView _imageViewProfile;
        public CardView _cardViewProfileImage;
        private AlertDialog.Builder _alertbuilderPhotoPick;
        public int getImage;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View profileInterns = inflater.Inflate(Resource.Layout.profileInternsFragment, container, false);
            _imageViewInternshipDetails = profileInterns.FindViewById<ImageView>(Resource.Id.interDetailsNextImageView);
            _imageViewChangePassword = profileInterns.FindViewById<ImageView>(Resource.Id.internChangePassNextImageView);
            _cardViewProfileImage = profileInterns.FindViewById<CardView>(Resource.Id.internCardView);
            _imageViewProfile = profileInterns.FindViewById<CircleImageView>(Resource.Id.profileImageImageView);

            _imageViewInternshipDetails.Click += _imageViewInternshipDetails_Click;
            _imageViewChangePassword.Click += _imageViewChangePassword_Click;
            _imageViewProfile.Click += _imageViewProfile_Click;

            ImageSetter(getImage);

            return profileInterns;
        }

        private void ImageSetter(int getImage)
        {
            _imageViewProfile.SetImageResource(getImage);
        }

        private void _imageViewProfile_Click(object sender, EventArgs e)
        {
           _alertbuilderPhotoPick = new AlertDialog.Builder(Activity);
           _alertbuilderPhotoPick.SetTitle("Select Profile");
          _alertbuilderPhotoPick.SetMessage("Select your Image");

          _alertbuilderPhotoPick.SetPositiveButton("Gallery", (senderAlert, args) =>
            {
                MyLayoutPickimage_Click();
            });

         _alertbuilderPhotoPick.SetNegativeButton("Camera", (senderAlert, args) =>
            {
                MyLayoutTakeimage_ClickAsync();
            });

            _alertbuilderPhotoPick.Show();
        }

        private async void MyLayoutTakeimage_ClickAsync()
        {
            var photo = await MediaPicker.CapturePhotoAsync();

         
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            {
                _imageViewProfile.SetImageBitmap(BitmapFactory.DecodeStream(stream));
            }
        }

        private async void MyLayoutPickimage_Click()
        {
            var res = await MediaPicker.PickPhotoAsync();
            if (res.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) || (res.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))) ;
            {
                var stream = await res.OpenReadAsync();
                _imageViewProfile.SetImageBitmap(BitmapFactory.DecodeStream(stream));

            }
        }

        private void _imageViewChangePassword_Click(object sender, EventArgs e)
        {
            Intent s = new Intent(Activity, typeof(ChangePasswordActivity));
            StartActivity(s);
        }

        private void _imageViewInternshipDetails_Click(object sender, EventArgs e)
        {
            Intent mentorDetials = new Intent(Activity, typeof(InternshipDetailsActivity));
            StartActivity(mentorDetials);
        }
    }
}