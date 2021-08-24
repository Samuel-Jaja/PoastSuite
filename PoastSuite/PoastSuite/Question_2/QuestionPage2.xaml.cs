using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage2 : ContentPage
    {
        DfpGradingCentre question2;
        public QuestionPage2()
        {
            InitializeComponent();
            question2 = new DfpGradingCentre(-2, 4, 1.6, 0.5, -1, -2, 0, 0);
            functionDisplay.Text = question2.solution.writeFunction();
            xValue.Text = question2.solution.X1[0, 0].ToString();
            yValue.Text = question2.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question2));
        }
    }
}