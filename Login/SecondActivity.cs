using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.Content;
using Android.App;

using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Login
{
    
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {


        
        Button btngetvalue;
        TextView txt1,txt2;
        string name;
        EditText ed1;
       // string path = Application.Context.FilesDir.Path;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SecondLayout);
            name = Intent.GetStringExtra("DATA_PASS"); //Get The Value  
           string path = Intent.GetStringExtra("PATH");
            btngetvalue = FindViewById<Button>(Resource.Id.btnclick);
            txt1= FindViewById<TextView>(Resource.Id.label);
            txt2 = FindViewById<TextView>(Resource.Id.label2);
            ed1 = FindViewById<EditText>(Resource.Id.name);
            //ISharedPreferences localnames = Application.Context.GetSharedPreferences("USERNAMES", FileCreationMode.Private);
            //ISharedPreferencesEditor localedit = localnames.Edit();
            txt1.Text = txt1.Text+" "+name;
            
            btngetvalue.Click += delegate
            {
                
                //txt2.Text = txt2.Text + " " + localnames.GetString("name", null);
                //localedit.PutString("name", ed1.Text);
                //localedit.Commit();
                System.IO.File.AppendAllText(path, " "+ed1.Text);
                // txt2.Text = txt2.Text + " " + localnames.GetString("name", null);
               String data= System.IO.File.ReadAllText(path);
                txt2.Text = data;
               
            };
        
    }
    }
}