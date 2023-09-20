using Android.App;
using Android.Content.PM;
using Android.OS;

using Com.Dynamsoft.Core;

namespace MauiAndroidMrz
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        public class LicenseVerificationListener : Java.Lang.Object, ILicenseVerificationListener
        {
            public void LicenseVerificationCallback(bool isSuccess, CoreException p1)
            {
                if (!isSuccess)
                {
                    System.Console.WriteLine(p1);
                }
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Your platform-specific code here
            LicenseManager.InitLicense("DLS2eyJoYW5kc2hha2VDb2RlIjoiMjAwMDAxLTE2NDk4Mjk3OTI2MzUiLCJvcmdhbml6YXRpb25JRCI6IjIwMDAwMSIsInNlc3Npb25QYXNzd29yZCI6IndTcGR6Vm05WDJrcEQ5YUoifQ==", this, new LicenseVerificationListener());
        }
    }
}