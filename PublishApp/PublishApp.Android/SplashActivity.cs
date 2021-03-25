using Android.App;
using Android.Content;
using Android.Content.Res;
using AndroidX.AppCompat.App;

namespace PublishApp.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash",
              MainLauncher = true,
              NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        //protected override void AttachBaseContext(Context @base)
        //{
        //    Configuration overrideConfiguration = new Configuration();
        //    overrideConfiguration = @base.Resources.Configuration;
        //    overrideConfiguration.SetToDefaults();
        //    var fontScale = overrideConfiguration.FontScale;
        //    overrideConfiguration.FontScale = (float)1;
        //    Context context = @base.CreateConfigurationContext(overrideConfiguration);
        //    base.AttachBaseContext(context);
        //}
    }
}
