using System;
using System.Collections.Generic;
using System.Text;

namespace PoastSuite
{
    public class DfpParameter1
    {
        public DfpParameter1(double _a, double _b, double _c, double _d, double _ee, double _f, double _fx, 
            double _g1x1,double _g1x2, double _g2x1, double _g2x2, double _g3x1, double _g3x2 , double _s1x1, double _s1x2, double _s2x1, double _s2x2, double _L1, double _L2, double _x2x1, double _x2x2, double _x3x1, double _x3x2, double _invSiT_qi, double _inv_qiT_Hi_qi, double _tolerance)
        {
            //this.a = _a;
            a = _a;
            b = _b;
            c = _c;
            d = _d;
            ee = _ee;
            f = _f;
            fx = _fx;
            g1x1 = _g1x1;
            g1x2 = _g1x2;
            g2x1 = _g2x1;
            g2x2 = _g2x2;
            g3x1 = _g3x1;
            g3x2 = _g3x2;
            

            L1 = _L1;
            L2 = _L2;

            s1x1 = _s1x1;
            s1x2 = _s1x2;
            s2x1 = _s2x1;
            s2x2 = _s2x2;

            x2x1 = _x3x1;
            x2x2 = _x3x2;
            x3x1 = _x3x1;
            x3x2 = _x3x2;
            invSiT_qi = _invSiT_qi;
            inv_qiT_Hi_qi = _inv_qiT_Hi_qi;
            Tolerance = _tolerance;                               //                    <<<<Tolerance

        }

        /*
        double myg2x1;
        double myg2x2;
        
        public DfpParameter1(double _g2x1, double _g2x2)
        {
            myg2x1 = _g2x1;
            myg2x2 = _g2x2;

        }
        */

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double ee { get; set; }
        public double f { get; set; }
        public double fx { get; set; }

        public double g1x1 { get; set; }
        public double g1x2 { get; set; }
        public double g2x1 { get; set; }
        public double g2x2 { get; set; }
        public double g3x1 { get; set; }
        public double g3x2 { get; set; }
        public double s1x1 { get; set; }
        public double s1x2 { get; set; }
        public double s2x1 { get; set; }
        public double s2x2 { get; set; }
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double x2x1 { get; set; }
        public double x2x2 { get; set; }
        public double x3x1 { get; set; }
        public double x3x2 { get; set; }
        public double invSiT_qi { get; set; }
        public double inv_qiT_Hi_qi { get; set; }
        public double Tolerance { get; set; }



        // DECLARATION OF VARIABLES AND ARRAYS USED for DPF PROJECT
        // Restructure

        /*
        private double[] gradeCheck1 = new double[10];
        public double [] GradeCheck1
        {
            get { return gradeCheck1; }
            set { gradeCheck1 = value; }
        }
        */


        
        
        
        

        
       

        
        

        

       
        

        
       
                       

       // double[] GradeData = new double[] { };
        
    }
}
