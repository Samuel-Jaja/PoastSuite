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
    public partial class DfpPage5 : ContentPage
    {
        public DfpPage5()
        {
            InitializeComponent();
        }


        async private void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            bool isEntryEmptyMark24 = string.IsNullOrEmpty(Users2x1.Text);
            if (isEntryEmptyMark24)
            {
                Global.Mark24 = 0;
            }
            else if (Global.X3x1 - double.Parse(Users2x1.Text) <= 0.100)
            {
                Global.Mark24 = 1;
            }
            else
            {
                Global.Mark24 = 0;
            }


            bool isEntryEmptyMark25 = string.IsNullOrEmpty(Users2x2.Text);
            if (isEntryEmptyMark25)
            {
                Global.Mark25 = 0;
            }
            else if (Global.X3x1 - double.Parse(Users2x2.Text) <= 0.100)
            {
                Global.Mark25 = 1;
            }
            else
            {
                Global.Mark25 = 0;
            }

            bool isEntryEmptyMark26 = string.IsNullOrEmpty(UserL2.Text);
            if (isEntryEmptyMark26)
            {
                Global.Mark26 = 0;
            }
            else if (Global.L2 - double.Parse(UserL2.Text) <= 0.100)
            {
                Global.Mark26 = 1;
            }
            else
            {
                Global.Mark26 = 0;
            }
            await Navigation.PushAsync(new DfpPage6());
        }

        async private void BackButtonIterationThreePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpPage4());
        }
    }
}