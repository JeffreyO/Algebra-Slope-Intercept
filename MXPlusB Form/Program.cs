using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXPlusB_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for variables
            Console.WriteLine("nX");    decimal nX = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("nY");    decimal nY = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("X+Y=n"); decimal XYn = Convert.ToDecimal(Console.ReadLine());
            //Does Conversion from Standard form to Slope Intercept
            nX /= -1;
            decimal M = nX / nY;
            decimal B = XYn / nY;
            //Print result to console
            Console.WriteLine("Y=" + M + "X+" + B);
            //Exit Prompt
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
