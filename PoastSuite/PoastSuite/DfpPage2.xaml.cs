using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpPage2 : ContentPage
    {
       

        public DfpPage2()
        {
            InitializeComponent();
           
        }


        async private void SolveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpPage3()); 
        }

        async private void BackButtonInputCoefPage_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new DfpPage());
        }


        

       


    }
}