using System;
using static System.Console;
namespace CSC240_03_01_DemoLogo_bpc
{
    class DemoLogo
    {
        static void Main()
        {
            Write("Our company is ");
            DisplayCompanyLogo();
        }
        private static void DisplayCompanyLogo()
        {
            WriteLine("See Sharp Optical");
            WriteLine("We prize your eyes");
        }
    }
}
