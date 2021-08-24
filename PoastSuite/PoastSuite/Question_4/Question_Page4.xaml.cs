using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastSuite.Question_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Question_Page4 : ContentPage
    {

        DfpGradingCentre question4;
        public Question_Page4()
        {
            InitializeComponent();
            question4 = new DfpGradingCentre(-2, 4, 1.7, 0.5, -1, -2, 0, 0);
            functionDisplay.Text = question4.solution.writeFunction();
            xValue.Text = question4.solution.X1[0, 0].ToString();
            yValue.Text = question4.solution.X1[1, 0].ToString();
        }

       async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpIterationPage1(question4));

        }
    }
}