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
        double p;
        public DfpPage5(double marks2)
        {
            p = marks2;
            InitializeComponent();
        }


        async private void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            var dfpParameter2 = new DfpParameter1(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0001);


            int m24;
            bool isEntryEmptyMark24 = string.IsNullOrEmpty(Users2x1.Text);
            if (isEntryEmptyMark24)
            {
                m24 = 0;
            }
            else if (dfpParameter2.s2x1 - double.Parse(Users2x1.Text) <= 0.100)
            {
                m24 = 1;
            }
            else
            {
                m24 = 0;
            }

            int m25;
            bool isEntryEmptyMark25 = string.IsNullOrEmpty(Users2x2.Text);
            if (isEntryEmptyMark25)
            {
                m25 = 0;
            }
            else if (dfpParameter2.s2x2 - double.Parse(Users2x2.Text) <= 0.100)
            {
                m25 = 1;
            }
            else
            {
                m25 = 0;
            }

            int m26;
            bool isEntryEmptyMark26 = string.IsNullOrEmpty(UserL2.Text);
            if (isEntryEmptyMark26)
            {
                m26 = 0;
            }
            else if (dfpParameter2.L2 - double.Parse(UserL2.Text) <= 0.100)
            {
                m26 = 1;
            }
            else
            {
                m26 = 0;
            }


            //===============
            int m27;
            bool isEntryEmptyMark27 = string.IsNullOrEmpty(UserX3x1.Text);
            if (isEntryEmptyMark27)
            {
                m27 = 0;
            }
            else if (dfpParameter2.x3x1 - double.Parse(UserX3x1.Text) == 0.000)
            {
               
                m27 = 1;
            }
            else
            {
                m27 = 0;
            }

            int m28;
            bool isEntryEmptyMark28 = string.IsNullOrEmpty(UserX3x2.Text);
            if (isEntryEmptyMark28)
            {
                m28 = 0;
            }
            else if (dfpParameter2.x3x2 - double.Parse(UserX3x2.Text) == 0.000)
            {
                m28 = 1;
            }
            else
            {
                m28 = 0;
            }

            int m29;
            bool isEntryEmptyMark29 = string.IsNullOrEmpty(Userg3x1.Text);
            if (isEntryEmptyMark29)
            {
                m29 = 0;
            }
            else if (dfpParameter2.g3x1 - double.Parse(Userg3x1.Text) == 0.000)
            {
                m29 = 1;
            }
            else
            {
                m29 = 0;
            }

            int m30;
            bool isEntryEmptyMark30 = string.IsNullOrEmpty(Userg3x2.Text);
            if (isEntryEmptyMark30)
            {
               m30 = 0;
            }
            else if (dfpParameter2.g3x2 - double.Parse(Userg3x2.Text) == 0.000)
            {
                m30 = 1;
            }
            else
            {
               m30 = 0;
            }
            

            double marks3;

            marks3 = m24 + m25 + m26 + m27 + m28 + m29 + m30 +p;
            
            await Navigation.PushAsync(new DfpPage6(marks3));
        }
            

        async private void BackButtonIterationThreePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpPage4(p));
        }
            
        }
    }
