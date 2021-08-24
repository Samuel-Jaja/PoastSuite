using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage3 : ContentPage
    {
        DfpGradingCentre question3;
        public QuestionPage3()
        {
            InitializeComponent();
            question3 = new DfpGradingCentre(-2, 4, 1.5, 0.4, -1, -2, 0, 0);
            functionDisplay.Text = question3.solution.writeFunction();
            xValue.Text = question3.solution.X1[0, 0].ToString();
            yValue.Text = question3.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question3));

        }
    }
}