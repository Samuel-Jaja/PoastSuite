using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage8 : ContentPage
    {
        DfpGradingCentre question8;
        public QuestionPage8()
        {
            InitializeComponent();
            question8 = new DfpGradingCentre(-2, 4, 1.8, 0.5, -1, -2, 0, 0);
            functionDisplay.Text = question8.solution.writeFunction();
            xValue.Text = question8.solution.X1[0, 0].ToString();
            yValue.Text = question8.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question8));
        }
    }
}