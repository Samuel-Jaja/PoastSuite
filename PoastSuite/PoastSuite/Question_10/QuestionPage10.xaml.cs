using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage10 : ContentPage
    {
        DfpGradingCentre question10;
        public QuestionPage10()
        {
            InitializeComponent();
            question10 = new DfpGradingCentre(-2, 4, 1.4, 0.7, -1, -2, 0, 0);
            functionDisplay.Text = question10.solution.writeFunction();
            xValue.Text = question10.solution.X1[0, 0].ToString();
            yValue.Text = question10.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question10));
        }
    }
}