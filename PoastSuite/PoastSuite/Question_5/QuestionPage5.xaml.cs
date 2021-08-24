using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage5 : ContentPage
    {
        DfpGradingCentre question5;
        public QuestionPage5()
        {
            
            InitializeComponent();
            question5 = new DfpGradingCentre(-2, 4, 1.8, 0.45, -1, -2, 0, 0);
            functionDisplay.Text = question5.solution.writeFunction();
            xValue.Text = question5.solution.X1[0, 0].ToString();
            yValue.Text = question5.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new DfpIterationPage1(question5));
        }
    }
}