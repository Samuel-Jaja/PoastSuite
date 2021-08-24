using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage9 : ContentPage
    {
        DfpGradingCentre question9;
        public QuestionPage9()
        {
            InitializeComponent();
            question9 = new DfpGradingCentre(-2, 4, 1.6, 0.55, -1, -2, 0, 0);
            functionDisplay.Text = question9.solution.writeFunction();
            xValue.Text = question9.solution.X1[0, 0].ToString();
            yValue.Text = question9.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question9));
        }
    }
}