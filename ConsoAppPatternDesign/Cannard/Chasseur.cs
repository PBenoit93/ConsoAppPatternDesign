using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class Chasseur
    {

        public void vise(IAnimal a)
        {
            Console.WriteLine("Pan");
            a.crier();
            a.fuir();
        } 
    }
}
