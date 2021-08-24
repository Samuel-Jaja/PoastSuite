using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoastSuite.Table;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage(string username)
        {
            //This code enables to remove navigation bar property 
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            LabelHelloFriend.Text = username;
        }

        public WelcomePage()
        {
        }

        async private void WelcomeLogoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private void WelcomeStartTechniqueButton_Clicked(object sender, EventArgs e)
        {

            //POAST Suite 1.0 Navigation centre for its Developers 
          
            if (hookesandjeevesCheckbox.IsChecked)
            { 
                neldermeadcheckbox.IsEnabled = false;
                DfpCheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
                Navigation.PushAsync(new MainPage());
                //Kaycee please change MainPage to your very first page for HJ
            }
            else if (neldermeadcheckbox.IsChecked)
            {
               
                DfpCheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
                hookesandjeevesCheckbox.IsEnabled = false;
                Navigation.PushAsync(new MainPage());
                //Belem please change DfpPage6 to your very first page for NM
            } 
            else if(DfpCheckbox.IsChecked)
            {
                neldermeadcheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
                hookesandjeevesCheckbox.IsEnabled = false;

                Navigation.PushAsync(new DfpPage());
            }
           
            else if (flectherandreevescheckbox.IsChecked)
            {
                neldermeadcheckbox.IsChecked = false;
                DfpCheckbox.IsChecked = false;
                hookesandjeevesCheckbox.IsChecked = false;
                Navigation.PushAsync(new MainPage());
                //Iruoma please change MainPage to your very first page for FR
            }
            else
            {
                 DisplayAlert("Error selecting a Module", "Please check (tick) a box", "Ok", "Cancel");
            }
        }

        private void Dfpcheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //if (e.Value==true)
            //{
            //    lblCheckeddpf.Text = "Great Choice for selecting a Gradient Method:DFP Technique";
            //}
            //else
            //{
            //    lblCheckeddpf.Text = "DFP Method is a Great Choice to Start";
            //}

        }
    }
}