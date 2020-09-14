using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Xamarin.Forms;

namespace PoastSuite
{
    public static class Global
    {
        public static void Init()
        {

        }

        private static string _Test { get; set; }

        public static string Test
        {
            get => _Test;
            set => _Test = value;
        }

        //Other Variables need to be here
        public static double G1x1 { get; set; }
        public static double G1x2 { get; set; }
        

        
    }
}
