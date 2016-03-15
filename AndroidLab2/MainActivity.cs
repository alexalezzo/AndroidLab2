using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;

namespace AndroidLab2
{
    [Activity(Label = "AndroidLab2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            Button btn = FindViewById<Button>(Resource.Id.btn_scale);
            btn.Click += OnButtonClick;
        }

        public void OnButtonClick(object sender, EventArgs ea)
        {
            Random ran = new Random();
            float xChange = (float)(ran.Next(50, 200)) / 100;
            float yChange = (float)(ran.Next(50, 200)) / 100;
            ImageView koala = FindViewById<ImageView>(Resource.Id.iv_koala);
            Animation anim = new ScaleAnimation(1f, xChange, 1f, yChange, 0.5f, 0.5f);
            anim.Duration = 300;
            anim.FillEnabled = true;
            anim.FillAfter = true;
            koala.StartAnimation(anim);
            
        }
    }
}

      


