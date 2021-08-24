using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage7 : ContentPage
    {
        DfpGradingCentre question7;
        public QuestionPage7()
        {
            InitializeComponent();
            question7 = new DfpGradingCentre(-2, 4, 2.0, 0.4, -1, -2, 0, 0);
            functionDisplay.Text = question7.solution.writeFunction();
            xValue.Text = question7.solution.X1[0, 0].ToString();
            yValue.Text = question7.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question7));
        }
    }
}