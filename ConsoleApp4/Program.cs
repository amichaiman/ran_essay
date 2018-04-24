using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Rectangle r = new Rectangle(10, 5, 30, 0);
            Rectangle r2 = new Rectangle(0, 5, 5, 0);

            r.Draw();
            r2.Draw();
        }
    }
}
