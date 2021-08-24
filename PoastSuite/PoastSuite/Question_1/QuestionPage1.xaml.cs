using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage1 : ContentPage
    {
        DfpGradingCentre question1;
        public QuestionPage1()
        {
            InitializeComponent();
            question1 = new DfpGradingCentre(-2, 4, 1.5, 0.5, -1, -2, 0, 0);
            functionDisplay.Text = question1.solution.writeFunction();
            xValue.Text = question1.solution.X1[0, 0].ToString();
            yValue.Text = question1.solution.X1[1, 0].ToString();
        }

        async private void solveButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question1));
        }
    }
}