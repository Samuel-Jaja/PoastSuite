

using System;
using PoastSuite.Question_1;
using PoastSuite.Question_2;
using PoastSuite.Question_3;
using PoastSuite.Question_4;
using PoastSuite.Question_5;
using PoastSuite.Question_6;
using PoastSuite.Question_7;
using PoastSuite.Question_8;
using PoastSuite.Question_9;
using PoastSuite.Question_10;
using PoastSuite.Question_11;
using PoastSuite.Question_12;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace PoastSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpQuestionSelection : ContentPage
    {
        public DfpQuestionSelection()
        {
            InitializeComponent();
        }

        async private void question1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage1());
        }

        async private void question2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage2());
        }

        async private void question3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage3());

        }

        async private void question4_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new Question_Page4());
        }

       async private void question5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage5());
        }

       async private void question6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage6());
        }

       async private void question7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage7());
        }

       async private void question8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage8());
        }

       async private void question9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage9());
        }

       async private void question10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage10());
        }

       async private void question11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage11());
        }

       async private void question12_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage12());
        }
    }
}