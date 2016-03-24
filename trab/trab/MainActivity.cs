using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace trab
{
	[Activity (Label = "Activity Main", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (global::trab.XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			EditText edittext = FindViewById<EditText> (Resource.Id.editText1);
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click +=  (sender, e) => {
				string txt = edittext.Text;

				var intent = new Intent(this, typeof(act2));
				intent.PutExtra("txt", txt);
				StartActivity(intent);
			};
		}
	}
}
