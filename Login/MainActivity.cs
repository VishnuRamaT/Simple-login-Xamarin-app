using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System.IO;

namespace Login
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity { 
        EditText username;  
        EditText password;
        Button loginbt;
        string path = Application.Context.FilesDir.Path;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            string filePath = Path.Combine(path, "test1.txt");
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            username = FindViewById<EditText>(Resource.Id.username);
            password = FindViewById<EditText>(Resource.Id.txtPassword);
            loginbt = FindViewById<Button>(Resource.Id.btnLogin);
            loginbt.Click += delegate {
                if (username.Text == "Vishnu"|| username.Text == "Joshua" && password.Text == "12345")
                {
                    Toast.MakeText(this, "Login successfully done!", ToastLength.Long).Show();
                    var intent = new Intent(this, typeof(SecondActivity));
                    intent.PutExtra("DATA_PASS", username.Text);
                    intent.PutExtra("PATH", filePath);//DATA_PASS is Identify the Value Pass variable  
                    this.StartActivity(intent);
                }
                else
                {
                      
                    Toast.MakeText(this, "Wrong credentials found!", ToastLength.Long).Show();
                }

            };
        }

    }
}