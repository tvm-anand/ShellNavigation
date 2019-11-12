using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PaTS.Models;
using PaTS.Views;
using PaTS.ViewModels;

namespace PaTS.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        

        public ItemsPage()
        {
            InitializeComponent();

            
        }

       public async void Timesheet_Tapped(object sender, EventArgs args)
        {
       

            await Navigation.PushAsync(new ItemDetailPage());

          
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

    
    }
}