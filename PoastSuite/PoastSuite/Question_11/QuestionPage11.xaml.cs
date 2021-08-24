using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage11 : ContentPage
    {
        DfpGradingCentre question11;
        public QuestionPage11()
        {
            InitializeComponent();
            question11 = new DfpGradingCentre(-2, 4, 3, 0.9, -2, -3, 0, 0);
            functionDisplay.Text = question11.solution.writeFunction();
            xValue.Text = question11.solution.X1[0, 0].ToString();
            yValue.Text = question11.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question11));
        }
    }
}