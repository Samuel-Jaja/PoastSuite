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

            Global.TotalMarks = Global.Mark1 + Global.Mark2 + Global.Mark3 + Global.Mark4 + Global.Mark5 + Global.Mark6 + Global.Mark7 + Global.Mark8 + Global.Mark9 + Global.Mark26;
            Global.Score = Global.TotalMarks / 10;
            Global.TotalScore = Math.Round(Global.Score * 100);
            UserScore.Text = Global.TotalScore + " % ".ToString();

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