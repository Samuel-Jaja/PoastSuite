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
        
        private double p;
        
        public DfpPage4(double marks)
        {
            p = marks;
            InitializeComponent();
        }

        async private void Next2ndIterationButton_Clicked(object sender, EventArgs e)
        {
            var dfpParameter1 = new DfpParameter1(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0001);
            //===================================CODE TO GRADE Iteration 2=======================================
            
            int m8;
            bool isEntryEmptyMark8 = string.IsNullOrEmpty(Userg2x1.Text);
            if (isEntryEmptyMark8)
            {
                m8 = 0;
            }
            else if (dfpParameter1.g2x1 - double.Parse(Userg2x1.Text) <= 0.100)
            {
                m8 = 1;
            }
            else
            {
                m8 = 0;
            }

            

            int m9;
            bool isEntryEmptyMark9 = string.IsNullOrEmpty(Userg2x2 .Text);
            if (isEntryEmptyMark9)
            {
                m9 = 0;
            }
            else if (dfpParameter1.g2x2 - double.Parse(Userg2x2 .Text) <= 0.100)
            {
                m9 = 1;
            }
            else
            {
                m9 = 0;
            }

           
            int m10;
            bool isEntryEmptyMark10 = string.IsNullOrEmpty(Userq1x1.Text);
            if (isEntryEmptyMark10)
            {
                m10 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userq1x1.Text) <= 0.100) ///
            {
                m10 = 1;
            }
            else
            {
                m10 = 0;
            }

            int m11;
            bool isEntryEmptyMark11 = string.IsNullOrEmpty(Userq1x2.Text);
            if (isEntryEmptyMark11)
            {
                m11 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userq1x2.Text) <= 0.100)///
            {
                m11 = 1;
            }
            else
            {
                m11 = 0;
            }

            //GRADING OF A1

            int m12;
            bool isEntryEmptyMark12 = string.IsNullOrEmpty(Usera11 .Text);
            if (isEntryEmptyMark12)
            {
               m12 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Usera11.Text) <= 0.100)///
            {
                m12 = 1;
            }
            else
            {
                m12 = 0;
            }

            int m13;
            bool isEntryEmptyMark13 = string.IsNullOrEmpty(Usera12.Text);
            if (isEntryEmptyMark13)
            {
               m13 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Usera12.Text) <= 0.100)
            {
                m13 = 1;
            }
            else
            {
                m13 = 0;
            }

            int m14;
            bool isEntryEmptyMark14 = string.IsNullOrEmpty(Usera21.Text);
            if (isEntryEmptyMark14)
            {
               m14 = 0;   //NOT SEEN TO GRADE
            }
            else if (dfpParameter1.a - double.Parse(Usera21.Text) <= 0.100)
            {
                m14 = 1;
            }
            else
            {
                m14 = 0;
            }

            int m15;
            bool isEntryEmptyMark15 = string.IsNullOrEmpty(Usera22.Text);
            if (isEntryEmptyMark15)
            {
                m15 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Usera22.Text) <= 0.100)
            {
                m15 = 1;
            }
            else
            {
                m15 = 0;
            }



            //GRADING OF B1

            int m16;
            bool isEntryEmptyMark16 = string.IsNullOrEmpty(Userb11.Text);
            if (isEntryEmptyMark16)
            {
                m16 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userb11.Text) <= 0.100)
            {
                m16 = 1;
            }
            else
            {
                m16 = 0;
            }

            int m17;
            bool isEntryEmptyMark17 = string.IsNullOrEmpty(Userb12.Text);
            if (isEntryEmptyMark17)
            {
                m17 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userb12.Text) <= 0.100)
            {
                m17 = 1;
            }
            else
            {
                m17 = 0;
            }

            int m18;
            bool isEntryEmptyMark18 = string.IsNullOrEmpty(Userb21.Text);
            if (isEntryEmptyMark18)
            {
                m18 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userb21.Text) <= 0.100)
            {
                m18 = 1;
            }
            else
            {
                m18 = 0;
            }

            int m19;
            bool isEntryEmptyMark19 = string.IsNullOrEmpty(Userb22.Text);
            if (isEntryEmptyMark19)
            {
                m19 = 0;
            }
            else if (dfpParameter1.a - double.Parse(Userb22.Text) <= 0.100)
            {
                m19 = 1;
            }
            else
            {
                m19 = 0;
            }

            //GRADING OF H2

            int m20;
            bool isEntryEmptyMark20 = string.IsNullOrEmpty(UserH2_11 .Text);
            if (isEntryEmptyMark20)
            {
                m20 = 0;
            }
            else if (dfpParameter1.a - double.Parse(UserH2_11.Text) <= 0.100)
            {
                m20 = 1;
            }
            else
            {
                m20 = 0;
            }

            int m21;
            bool isEntryEmptyMark21 = string.IsNullOrEmpty(UserH2_12.Text);
            if (isEntryEmptyMark21)
            {
                m21 = 0;
            }
            else if (dfpParameter1.a - double.Parse(UserH2_12.Text) <= 0.100)
            {
                m21 = 1;
            }
            else
            {
                m21 = 0;
            }

            int m22;
            bool isEntryEmptyMark22 = string.IsNullOrEmpty(UserH2_21.Text);
            if (isEntryEmptyMark22)
            {
                m22 = 0;
            }
            else if (dfpParameter1.a - double.Parse(UserH2_21.Text) <= 0.100)
            {
                m22 = 1;
            }
            else
            {
                m22 = 0;
            }

            int m23;
            bool isEntryEmptyMark23 = string.IsNullOrEmpty(UserH2_22.Text);
            if (isEntryEmptyMark23)
            {
                m23 = 0;
            }
            else if (dfpParameter1.a - double.Parse(UserH2_22.Text) <= 0.100)
            {
                m23 = 1;
            }
            else
            {
                m23 = 0;
            }
            


            double marks2;
            //marks2 = m8 + p;
            marks2 = m8 + m9 + m10 + m11 + m12 + m13 + m14 + m15 + m16 + m17 + m18 + m19 + m20 + m21 + m22 + m23 + p;



            await Navigation.PushAsync(new DfpPage5(marks2));
        }

       async private void BackButtonIterationTwoPage_Clicked(object sender, EventArgs e)
       {
           await Navigation.PushAsync(new DfpPage3());
       }

        
        
    }
}