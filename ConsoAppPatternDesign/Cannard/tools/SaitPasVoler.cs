using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard.tools
{
    public class SaitPasVoler : IComportementVol
    {
        public void voler()
        {
            Console.WriteLine("gros effort mais pour rien");
        }
    }
}
