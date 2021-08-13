using DemoProject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static DemoProject.Model.DataModel;

namespace DemoProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoListPage : ContentPage
    {
        StoreList ObjContactList = new StoreList();

        public string taskstatus1;
        public ToDoListPage()
        {
            InitializeComponent();
            GetStoreData();
            BindingContext = this;
        }

        void GetStoreData()
        {
           string jsonFileName = "DemoProject.LocalJson.StoreData.json";
            var assembly = typeof(ToDoListPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(jsonFileName);
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                ObjContactList = JsonConvert.DeserializeObject<StoreList>(jsonString);
            }
            //Binding listview with json string     
             listviewStores.ItemsSource = ObjContactList.StoreDetails;






        }
    }
}