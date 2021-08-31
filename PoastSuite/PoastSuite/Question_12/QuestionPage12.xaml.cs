using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage12 : ContentPage
    {
        DfpGradingCentre question12;
        public QuestionPage12()
        {
            InitializeComponent();
            question12 = new DfpGradingCentre(-2, 4, 5, 0.7, -2, -3, 0, 0);
            functionDisplay.Text = question12.solution.writeFunction();
            xValue.Text = question12.solution.X1[0, 0].ToString();
            yValue.Text = question12.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question12));
        }
    }
}