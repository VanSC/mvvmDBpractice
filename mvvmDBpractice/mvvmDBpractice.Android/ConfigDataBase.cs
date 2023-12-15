using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mvvmDBpractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using mvvmDBpractice.Droid;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace mvvmDBpractice.Droid
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}