using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PoastSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpPage3 : ContentPage
    {
        public DfpPage3()
        {
            InitializeComponent();
            //g1x1.Text = dfx1.ToString();
        }

        async private void NextIterationButton_Clicked(object sender, EventArgs e)
        {
            //NOTE: gi (Gradient Vector), Xi (Starting Point) and Si (Search Direction) are all column vectors 

            //Step a : Select Initial point [X1] and n x n positive definite symmetric Hi. Usually Hi = I (Unit Matrix)
            var dfpParameter1 = new DfpParameter1(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0, 0.0001);

            // COEFFICIENTS OF f(x) in Array(Coef) but passed to variables a, b, c, d e, f
           
            double[] Coef = new double[] { 1.5, 0.5, -1, -2, 0, 0 };

            dfpParameter1.a = Coef[0];
            dfpParameter1.b = Coef[1];
            dfpParameter1.c = Coef[2];
            dfpParameter1.d = Coef[3];
            dfpParameter1.ee = Coef[4];
            dfpParameter1.f = Coef[5];

            double[,] X1 = new double[,] { };
            X1 = new double[,]
            {
                   {-2},
                   {4}
            };

            double[,] H1 = new double[,] { };
            //n x n Positive definite symmetric matrix Hi 
            H1 = new double[,]
            {
                     {1,0}, 
                     {0,1}
            };



            //MODEL (fx Equation)
            dfpParameter1.fx = (dfpParameter1.a * Math.Pow(X1[0, 0], 2)) + (dfpParameter1.b * Math.Pow(X1[1, 0], 2)) + (dfpParameter1.c * X1[0, 0] * X1[1, 0]) + (dfpParameter1.d * X1[0, 0]) + (dfpParameter1.ee * Math.Pow(X1[1, 0], 2)) + dfpParameter1.f;

            //Step b:

            //Partial Diff wrt x1
            dfpParameter1.g1x1 = (2 * dfpParameter1.a * X1[0, 0]) + (dfpParameter1.c * X1[1, 0]) + dfpParameter1.d;
            
            //Partial Diff wrt x2
            dfpParameter1.g1x2 = (2 * dfpParameter1.b * X1[1, 0]) + (dfpParameter1.c * X1[0, 0]) + (2 * dfpParameter1.ee * X1[1, 0]);

            //Passing the values of g1x1 and g1x2 to matrix g1 (gradient vector)
            double[,] g1 = new double[,] { };

            g1 = new double[,]
            {
                  {dfpParameter1.g1x1},
                  {dfpParameter1.g1x2}
            };

            //The dimensions of the Matrices being multiplied determines the nature of the dimension of the resultant matrix array holding the answer of the matrix multplication.
            //NOTE:If Column of first matrix = Row of Second matrix then they can be multiplied/
            // 2x2 * 2x1
            double[,] S1 = new double[,] { };
            S1 = Program1.MatrixMultiplication(H1, g1);
            S1 = Program1.ScalarMatrixMultiplication(S1, -1);

            dfpParameter1.s1x1 = S1[0, 0];
            dfpParameter1.s1x2 = S1[1, 0];

            S1 = new double[,]
            {
                  {dfpParameter1.s1x1},
                  {dfpParameter1.s1x2}
            };


            //x2x2 = (double)Math.Round(Convert.ToDecimal(X2[1, 0]), 4);
            //Step c: 
            dfpParameter1.L1 = -(2 * (dfpParameter1.a * X1[0, 0] * S1[0, 0]) + 2 * (dfpParameter1.b * X1[1, 0] * S1[1, 0]) + dfpParameter1.c * X1[0, 0] * S1[1, 0] + dfpParameter1.c * X1[1, 0] * S1[0, 0] + dfpParameter1.d * S1[0, 0]) / ((2 * (dfpParameter1.a * S1[0, 0] * S1[0, 0]) + (2 * (dfpParameter1.b * S1[1, 0] * S1[1, 0]) + (2 * (dfpParameter1.c * S1[0, 0] * S1[1, 0])))));
            dfpParameter1.L1 = Math.Round(Convert.ToDouble(dfpParameter1.L1), 4);


            // L2 = -((-0.9490 * a) + (-3.237 * b) + (1.1074 * c) + (0.6935 * c) + (0.7241 * d)) / ((0.1925 * a) + (1.0486 * b) - (0.4492 * c));

            // Also solve for L2 in this nature


            for (int i = 1; Math.Abs(dfpParameter1.g1x1) >= dfpParameter1.Tolerance && Math.Abs(dfpParameter1.g1x2) >= dfpParameter1.Tolerance; i++)
            {
                //Algorithm d: Test the new point for convergence.If xi+1 is optimal, terminate the iteration process, otherwise proceed to Algorithm e

                double[,] X2 = new double[,] { };
                double[,] g2 = new double[,] { };
                double[,] X3 = new double[,] { };
                double[,] g3 = new double[,] { };

                if (i == 1)
                {
                    double[,] L1S1 = new double[,] { };
                    L1S1 = Program1.ScalarMatrixMultiplication(S1, dfpParameter1.L1);

                    // Initialization of X2

                    X2 = new double[,]
                    {
                       {0},
                       {0}
                    };

                    X2[0, 0] = X1[0, 0] + L1S1[0, 0];
                    X2[1, 0] = X1[1, 0] + L1S1[1, 0];

                    //Console.WriteLine("Hence X3 =[{0},{1}] is the required minimum point and X3 is Optimal", Math.Round(Convert.ToDecimal(X3[0, 0]), 0), Math.Round(Convert.ToDecimal(X3[1, 0]), 0));

                    dfpParameter1.x2x1 = Math.Round(Convert.ToDouble(X2[0, 0]), 4);
                    dfpParameter1.x2x2 = Math.Round(Convert.ToDouble(X2[1, 0]), 4);

                    X2 = new double[,]
                    {
                       { dfpParameter1.x2x1},
                       { dfpParameter1.x2x2}
                    };

                    //Partial Diff wrt x1
                    dfpParameter1.g2x1 = (2 * dfpParameter1.a * X2[0, 0]) + (dfpParameter1.c * X2[1, 0]) + dfpParameter1.d;
                    //Partial Diff wrt x2
                    dfpParameter1.g2x2 = (2 * dfpParameter1.b * X2[1, 0]) + (dfpParameter1.c * X2[0, 0]) + (2 * dfpParameter1.ee * X2[1, 0]);



                    g2 = new double[,]
                    {
                       { dfpParameter1.g2x1},
                       { dfpParameter1.g2x2}
                    };
                    dfpParameter1.g2x1 = Math.Round(Convert.ToDouble(g2[0, 0]), 4);
                    dfpParameter1.g2x2 = Math.Round(Convert.ToDouble(g2[1, 0]), 4);

                    //Console.WriteLine("============Iteration [{0}]============", i);
                    //Console.WriteLine("X2 (Search Point X2):");
                    //PrintMatrix1(X2);
                    //Console.WriteLine();
                    //Console.WriteLine("The Values of X2 are x1 = {0} and x2 = {1}", Math.Round(Convert.ToDecimal(X2[0, 0]), 3), Math.Round(Convert.ToDecimal(X2[1, 0]), 3));

                    //Console.WriteLine("The gradient vector g2 are  df(x)/dx1 = {0}, where as df(x)/dx2 = {1},", Math.Round(Convert.ToDecimal(g2x1), 3), Math.Round(Convert.ToDecimal(g2x2), 3));

                    dfpParameter1.g1x1 = dfpParameter1.g2x1;
                    dfpParameter1.g2x2 = dfpParameter1.g2x2;
                }
                else if (i == 2)
                {
                    //Algorithm e : Update H matrix as follows: Hi+1 = Hi + Ai + Bi
                    //Global.L2 = 1.7058;
                    double[,] q = new double[,] { };
                    q = new double[,]
                    {
                      {0},
                      {0}
                    };

                    q[0, 0] = g2[0, 0] - g1[0, 0];
                    q[1, 0] = g2[1, 0] - g1[1, 0];

                    double q1q1 = Math.Round(Convert.ToDouble(q[0, 0]), 4);
                    double q2q2 = Math.Round(Convert.ToDouble(q[1, 0]), 4);


                    //Evaluation to obtain A1
                    double[,] Si_SiT = new double[,] { };
                    double[,] SiT_qi = new double[,] { };

                    Si_SiT = Program1.MatrixMultiplication(S1, Program1.TransposeMatrix(S1));   //Si*Si'
                    SiT_qi = Program1.MatrixMultiplication(Program1.TransposeMatrix(S1), q);    //Si'*qi
                    dfpParameter1.invSiT_qi = 1 / SiT_qi[0, 0];

                    double[,] A1 = new double[,] { };
                    A1 = Program1.ScalarMatrixMultiplication(Si_SiT, dfpParameter1.invSiT_qi);

                    //A1 pass to Global class for grading purpose
                    // double _A1_00 = Math.Round(Convert.ToDouble(A1[0, 0]), 4);
                    //double _A1_01 = Math.Round(Convert.ToDouble(A1[0, 1]), 4);
                    //double _A1_10 = Math.Round(Convert.ToDouble(A1[1, 0]), 4);
                    //double _A1_11 = Math.Round(Convert.ToDouble(A1[1, 1]), 4);


                    //double[,] Aa = ScalarMatrixMultiplication(A, L2);   //ASK PROF

                    //Evaluation to obtain B1
                    double[,] Hq = new double[,] { };
                    double[,] Hq_HqT = new double[,] { };

                    double[,] qiT_Hi_qi = new double[,] { };

                    double[,] B1 = new double[,] { };
                    Hq = Program1.MatrixMultiplication(H1, q);
                    Program1.TransposeMatrix(Hq);
                    Hq_HqT = Program1.MatrixMultiplication(Hq, Program1.TransposeMatrix(Hq)); // (Hq)*(Hq)'
                    Program1.TransposeMatrix(q);
                    qiT_Hi_qi = Program1.MatrixMultiplication(Program1.TransposeMatrix(q), Hq);  //q'*(Hq)
                    dfpParameter1.inv_qiT_Hi_qi = -1 / qiT_Hi_qi[0, 0];
                    B1 = Program1.ScalarMatrixMultiplication(Hq_HqT, dfpParameter1.inv_qiT_Hi_qi);

                    //B1 pass to Global class for grading purpose
                    //double _B1_00 = Math.Round(Convert.ToDouble(B1[0, 0]), 4);
                    //double _B1_01 = Math.Round(Convert.ToDouble(B1[0, 1]), 4);
                    //double _B1_10 = Math.Round(Convert.ToDouble(B1[1, 0]), 4);
                    //double _B1_11 = Math.Round(Convert.ToDouble(B1[1, 1]), 4);


                    //Initialization of H2
                    double[,] H2 = new double[,] { };
                    H2 = new double[,]
                    {
                       {0,0},
                       {0,0}
                    };

                    // Addition of Matrix H1, A1 and B1 using indexing to obtain H2 ==> H1 + A1 + B1
                    H2[0, 0] = H1[0, 0] + A1[0, 0] + B1[0, 0];
                    H2[0, 1] = H1[0, 1] + A1[0, 1] + B1[0, 1];
                    H2[1, 0] = H1[1, 0] + A1[1, 0] + B1[1, 0];
                    H2[1, 1] = H1[1, 1] + A1[1, 1] + B1[1, 1];

                    //H2 pass to Global class for grading purpose
                    // double _H2_00 = Math.Round(Convert.ToDouble(H2[0, 0]), 4);
                    // double _H2_01 = Math.Round(Convert.ToDouble(H2[0, 1]), 4);
                    // double _H2_10 = Math.Round(Convert.ToDouble(H2[1, 0]), 4);
                    // double _H2_11 = Math.Round(Convert.ToDouble(H2[1, 1]), 4);


                    double[,] S2 = new double[,] { };
                    S2 = Program1.MatrixMultiplication(H2, g2);
                    S2 = Program1.ScalarMatrixMultiplication(S2, -1);

                    double _S2x1 = Math.Round(Convert.ToDouble(S2[0, 0]), 4);
                    double _S2x2 = Math.Round(Convert.ToDouble(S2[1, 0]), 4);

                    S2 = new double[,]
                    {
                      {_S2x1},
                      {_S2x2}
                    };

                    dfpParameter1.L2 = -(2 * (dfpParameter1.a * X2[0, 0] * S2[0, 0]) + 2 * (dfpParameter1.b * X2[1, 0] * S2[1, 0]) + dfpParameter1.c * X2[0, 0] * S2[1, 0] + dfpParameter1.c * X2[1, 0] * S2[0, 0] + dfpParameter1.d * S2[0, 0]) / ((2 * (dfpParameter1.a * S2[0, 0] * S2[0, 0]) + (2 * (dfpParameter1.b * S2[1, 0] * S2[1, 0]) + (2 * (dfpParameter1.c * S2[0, 0] * S2[1, 0])))));
                    double[,] L2S2 = new double[,] { };
                    L2S2 = Program1.ScalarMatrixMultiplication(S2, dfpParameter1.L2);

                    //Initialization of X3

                    X3 = new double[,]
                    {
                       {0},
                       {0}
                    };

                    X3[0, 0] = X2[0, 0] + L2S2[0, 0];
                    X3[1, 0] = X2[1, 0] + L2S2[1, 0];

                    dfpParameter1.g3x1 = Math.Round(Convert.ToDouble(X3[0, 0]), 4);
                    dfpParameter1.g3x2 = Math.Round(Convert.ToDouble(X3[1, 0]), 4);

                    X3 = new double[,]
                    {
                       {dfpParameter1.g3x1},
                       {dfpParameter1.g3x2}
                    };

                    //Partial Diff wrt x1
                    dfpParameter1.g3x1 = (2 * dfpParameter1.a * X3[0, 0]) + (dfpParameter1.c * X3[1, 0]) + dfpParameter1.d;
                    //Partial Diff wrt x2
                    dfpParameter1.g3x2 = (2 * dfpParameter1.b * X3[1, 0]) + (dfpParameter1.c * X3[0, 0]) + (2 * dfpParameter1.ee * X3[1, 0]);

                    g3 = new double[,]
                    {
                       {dfpParameter1.g3x1},
                       {dfpParameter1.g3x2}
                    };

                    dfpParameter1.g3x1 = Math.Round(Convert.ToDouble(dfpParameter1.g3x1), 4);
                    dfpParameter1.g3x2 = Math.Round(Convert.ToDouble(dfpParameter1.g3x2), 4);



                    //Console.WriteLine();
                    //Console.WriteLine("============Iteration [{0}]============", i);
                    //Console.WriteLine("X3 (Search Point 3):");
                    //PrintMatrix1(X3);
                    //Console.WriteLine();
                    //Console.WriteLine("The Values of X3 are x1 = {0} and x2 = {1}", Math.Round(Convert.ToDecimal(X3[0, 0]), 3), Math.Round(Convert.ToDecimal(X3[1, 0]), 3));

                    //Console.WriteLine("The gradient vector g3 are  df(x)/dx1 = {0}, where as df(x)/dx2 = {1},", Math.Round(Convert.ToDecimal(g3x1), 3), Math.Round(Convert.ToDecimal(g3x2), 3));
                    //Console.WriteLine();
                    //Console.WriteLine("Hence X3 =[{0},{1}] is the required minimum point and X3 is Optimal", Math.Round(Convert.ToDecimal(X3[0, 0]), 0), Math.Round(Convert.ToDecimal(X3[1, 0]), 0));
                    //Console.WriteLine();

                    dfpParameter1.g1x1 = dfpParameter1.g3x1;
                    dfpParameter1.g3x1 = dfpParameter1.g3x1;
                }

                else
                { }
            }


            //g1x1.Text = dfx1.ToString();
            //UserL1.Text = g3[0,0].ToString();
            //UserX2x1.Text = S1[0, 0].ToString();


            //===================================CODE TO GRADE THE USER======================================

            // GradeData = new double[] { g1[0, 0], g1[1, 0], s1x1, s1x2, L1, X2[0, 0], X2[1, 0] };

            // double marks;
            int m1 = 0;
            bool isEntryEmptyMark1 = string.IsNullOrEmpty(Userg1x1.Text);
            if (isEntryEmptyMark1)
            {
                m1 = 0;
            }
            else if (dfpParameter1.g1x1 - double.Parse(Userg1x1.Text) <= 0.010)
            {
                m1 = 1;
            }
            else
            {
                m1 = 0;
            }

            // double sc = (m1 / 7) * 100;
            //Userg1x2.Text = sc.ToString();


            int m2 = 0;
            bool isEntryEmptyMark2 = string.IsNullOrEmpty(Userg1x2.Text);
            if (isEntryEmptyMark2)
            {
                m2 = 0;
            }
            else if (dfpParameter1.g1x2 - double.Parse(Userg1x2.Text) <= 0.100)
            {
                m2 = 1;
            }
            else
            {
                m2 = 0;
            }

            int m3 = 0;
            bool isEntryEmptyMark3 = string.IsNullOrEmpty(Users1x1.Text);
            if (isEntryEmptyMark3)
            {
                m3 = 0;
            }
            else if (dfpParameter1.s1x1 - double.Parse(Users1x1.Text) <= 0.100)
            {
                m3 = 1;
            }
            else
            {
                m3 = 0;
            }

            int m4;
            bool isEntryEmptyMark4 = string.IsNullOrEmpty(Users1x2.Text);
            if (isEntryEmptyMark4)
            {
                m4 = 0;
            }
            else if (dfpParameter1.s1x2 - double.Parse(Users1x2.Text) <= 0.100)
            {
                m4 = 1;
            }
            else
            {
                m4 = 0;
            }

            int m5;
            bool isEntryEmptyMark5 = string.IsNullOrEmpty(UserL1.Text);
            if (isEntryEmptyMark5)
            {
                m5 = 0;
            }
            else if (dfpParameter1.L1 - double.Parse(UserL1.Text) <= 0.100)
            {
                m5 = 1;
            }
            else
            {
                m5 = 0;
            }

            int m6;
            bool isEntryEmptyMark6 = string.IsNullOrEmpty(UserX2x1.Text);
            if (isEntryEmptyMark6)
            {
                m6 = 0;
            }
            else if (dfpParameter1.x2x1 - double.Parse(UserX2x2.Text) <= 0.100)
            {
                m6 = 1;
            }
            else
            {
                m6 = 0;
            }

            int m7;
            bool isEntryEmptyMark7 = string.IsNullOrEmpty(UserX2x2.Text);
            if (isEntryEmptyMark7)
            {
                m7 = 0;
            }
            else if (dfpParameter1.x2x2 - double.Parse(UserX2x2.Text) <= 0.100)
            {
                m7 = 1;
            }
            else
            {
                m7 = 0;
            }


            double marks = m1 + m2 + m3 + m4 + m5 + m6 + m7;

            await Navigation.PushAsync(new DfpPage4(marks));
        }

        async private void BackButtonIterationOnePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpPage2());
        }


        
    }

}

    
