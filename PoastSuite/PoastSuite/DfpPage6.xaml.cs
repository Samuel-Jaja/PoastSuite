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
    public partial class DfpPage6 : ContentPage
    {
        public DfpPage6()
        {
            //This code enables to remove navigation bar property 
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {

            Global.TotalMarks = Global.Mark1 + Global.Mark2 + Global.Mark3 + Global.Mark4 + Global.Mark5 + Global.Mark6 + Global.Mark7 + Global.Mark8 + Global.Mark9 + Global.Mark10 + Global.Mark11 + Global.Mark12 + Global.Mark13 + Global.Mark14 + Global.Mark15 + Global.Mark16 + Global.Mark17 + Global.Mark18 + Global.Mark19 + Global.Mark20 + Global.Mark21 + Global.Mark22 + Global.Mark23 + Global.Mark24 + Global.Mark25 + Global.Mark26 + Global.Mark27 + Global.Mark28 + Global.Mark29 + Global.Mark30;
               
            Global.Score = Global.TotalMarks/30;
            Global.TotalScore = Math.Round(Convert.ToDouble(Global.Score * 100),2);
            UserScore.Text = Global.TotalScore +   " % ".ToString();

        }

        async private void BackButtonIterationFourPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpPage5());
        }

       async private void ExitDFPModule_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new WelcomePage());
        }
    }
}