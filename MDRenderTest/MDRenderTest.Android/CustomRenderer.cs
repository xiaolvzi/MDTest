using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MDRenderTest.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
[assembly: ExportRenderer(typeof(Xamarin.Forms.MasterDetailPage), typeof(CustomRenderer))]
namespace MDRenderTest.Droid
{
    public class CustomRenderer : MasterDetailPageRenderer
    {
        public CustomRenderer(Context context) : base(context)
        {
        }
    }
}