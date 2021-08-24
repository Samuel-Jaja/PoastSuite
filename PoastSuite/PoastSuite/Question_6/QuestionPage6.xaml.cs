using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage6 : ContentPage
    {
        DfpGradingCentre question6;
        public QuestionPage6()
        {
            InitializeComponent();
            question6 = new DfpGradingCentre(-2, 4, 1.9, 0.6, -1, -2, 0, 0);
            functionDisplay.Text = question6.solution.writeFunction();
            xValue.Text = question6.solution.X1[0, 0].ToString();
            yValue.Text = question6.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question6));
        }
    }
}