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

namespace trab
{
	[Activity (Label = "Activity 2")]			
	public class act2 : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.act2);

			TextView txtv = FindViewById<TextView> (Resource.Id.textView1);

			txtv.Text = Intent.Extras.GetString ("txt");


		}
	}
}

