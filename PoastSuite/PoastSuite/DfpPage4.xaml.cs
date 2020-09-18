using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PoastSuite.Table;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpPage4 : ContentPage
    {
        
        public DfpPage4()
        {
            InitializeComponent();
            
        }

        private void NextIterationButton_Clicked(object sender, EventArgs e)
        {

        }

        async private void Next2ndIterationButton_Clicked(object sender, EventArgs e)
        {
            ////===================================CODE TO GRADE THE USER======================================
            ////GradeData = new double[] { g1[0, 0], g1[1, 0], s1x1, s1x2, L1, X2[0, 0], X2[1, 0] };


            //GradeData = new double[] { g2[0, 0], g2[1, 0], s2x1, s2x2, L2, X3[0, 0], X3[1, 0] };

            bool isEntryEmptyMark8 = string.IsNullOrEmpty(Userg2x1.Text);
            if (isEntryEmptyMark8)
            {
                Global.Mark8 = 0;
            }
            else if (Global.G2x1 - double.Parse(Userg2x1.Text) <= 0.100)
            {
                Global.Mark8 = 1;
            }
            else
            {
                Global.Mark8 = 0;
            }

            bool isEntryEmptyMark9 = string.IsNullOrEmpty(Userg2x2 .Text);
            if (isEntryEmptyMark9)
            {
                Global.Mark9 = 0;
            }
            else if (Global.G2x2 - double.Parse(Userg2x2 .Text) <= 0.100)
            {
                Global.Mark9 = 1;
            }
            else
            {
                Global.Mark9 = 0;
            }


            bool isEntryEmptyMark10 = string.IsNullOrEmpty(Userq1x1.Text);
            if (isEntryEmptyMark10)
            {
                Global.Mark10 = 0;
            }
            else if (Global.L2 - double.Parse(Userq1x1.Text) <= 0.100)
            {
                Global.Mark10 = 1;
            }
            else
            {
                Global.Mark10 = 0;
            }

            bool isEntryEmptyMark11 = string.IsNullOrEmpty(Userq1x2.Text);
            if (isEntryEmptyMark11)
            {
                Global.Mark11 = 0;
            }
            else if (Global.L2 - double.Parse(Userq1x2.Text) <= 0.100)
            {
                Global.Mark11 = 1;
            }
            else
            {
                Global.Mark11 = 0;
            }

            //GRADING OF A1

            bool isEntryEmptyMark12 = string.IsNullOrEmpty(Usera11 .Text);
            if (isEntryEmptyMark12)
            {
                Global.Mark12 = 0;
            }
            else if (Global.L2 - double.Parse(Usera11.Text) <= 0.100)
            {
                Global.Mark12 = 1;
            }
            else
            {
                Global.Mark12 = 0;
            }


            bool isEntryEmptyMark13 = string.IsNullOrEmpty(Usera12.Text);
            if (isEntryEmptyMark13)
            {
                Global.Mark13 = 0;
            }
            else if (Global.L2 - double.Parse(Usera12.Text) <= 0.100)
            {
                Global.Mark13 = 1;
            }
            else
            {
                Global.Mark13 = 0;
            }

            bool isEntryEmptyMark14 = string.IsNullOrEmpty(Usera21.Text);
            if (isEntryEmptyMark14)
            {
                Global.Mark14 = 0;
            }
            else if (Global.L2 - double.Parse(Usera21.Text) <= 0.100)
            {
                Global.Mark14 = 1;
            }
            else
            {
                Global.Mark14 = 0;
            }


            bool isEntryEmptyMark15 = string.IsNullOrEmpty(Usera22.Text);
            if (isEntryEmptyMark15)
            {
                Global.Mark15 = 0;
            }
            else if (Global.L2 - double.Parse(Usera22.Text) <= 0.100)
            {
                Global.Mark15 = 1;
            }
            else
            {
                Global.Mark15 = 0;
            }



            //GRADING OF B1

            bool isEntryEmptyMark16 = string.IsNullOrEmpty(Userb11.Text);
            if (isEntryEmptyMark16)
            {
                Global.Mark16 = 0;
            }
            else if (Global.L2 - double.Parse(Userb11.Text) <= 0.100)
            {
                Global.Mark16 = 1;
            }
            else
            {
                Global.Mark16 = 0;
            }


            bool isEntryEmptyMark17 = string.IsNullOrEmpty(Userb12.Text);
            if (isEntryEmptyMark17)
            {
                Global.Mark17 = 0;
            }
            else if (Global.L2 - double.Parse(Userb12.Text) <= 0.100)
            {
                Global.Mark17 = 1;
            }
            else
            {
                Global.Mark17 = 0;
            }

            bool isEntryEmptyMark18 = string.IsNullOrEmpty(Userb21.Text);
            if (isEntryEmptyMark18)
            {
                Global.Mark18 = 0;
            }
            else if (Global.L2 - double.Parse(Userb21.Text) <= 0.100)
            {
                Global.Mark18 = 1;
            }
            else
            {
                Global.Mark18 = 0;
            }


            bool isEntryEmptyMark19 = string.IsNullOrEmpty(Userb22.Text);
            if (isEntryEmptyMark19)
            {
                Global.Mark19 = 0;
            }
            else if (Global.L2 - double.Parse(Userb22.Text) <= 0.100)
            {
                Global.Mark19 = 1;
            }
            else
            {
                Global.Mark19 = 0;
            }

            //GRADING OF H2

            bool isEntryEmptyMark20 = string.IsNullOrEmpty(UserH2_11 .Text);
            if (isEntryEmptyMark20)
            {
                Global.Mark20 = 0;
            }
            else if (Global.L2 - double.Parse(UserH2_11.Text) <= 0.100)
            {
                Global.Mark20 = 1;
            }
            else
            {
                Global.Mark20 = 0;
            }


            bool isEntryEmptyMark21 = string.IsNullOrEmpty(UserH2_12.Text);
            if (isEntryEmptyMark21)
            {
                Global.Mark21 = 0;
            }
            else if (Global.L2 - double.Parse(UserH2_12.Text) <= 0.100)
            {
                Global.Mark21 = 1;
            }
            else
            {
                Global.Mark21 = 0;
            }

            bool isEntryEmptyMark22 = string.IsNullOrEmpty(UserH2_21.Text);
            if (isEntryEmptyMark22)
            {
                Global.Mark22 = 0;
            }
            else if (Global.L2 - double.Parse(UserH2_21.Text) <= 0.100)
            {
                Global.Mark22 = 1;
            }
            else
            {
                Global.Mark22 = 0;
            }


            bool isEntryEmptyMark23 = string.IsNullOrEmpty(UserH2_22.Text);
            if (isEntryEmptyMark23)
            {
                Global.Mark23 = 0;
            }
            else if (Global.L2 - double.Parse(UserH2_22.Text) <= 0.100)
            {
                Global.Mark23 = 1;
            }
            else
            {
                Global.Mark23 = 0;
            }


            await Navigation.PushAsync(new DfpPage5());
        }

       async private void BackButtonIterationTwoPage_Clicked(object sender, EventArgs e)
       {
           await Navigation.PushAsync(new DfpPage3());
       }

        
        
    }
}