using ConsoAppPatternDesign.Cannard.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class Mandarin : Canard
    {
        public Mandarin()
        {
            comportementVol = new VolAvecAiles();
            comportementCancan = new Cancan();
        }

        public override void afficher()
        {
            Console.WriteLine("c'est un mandarin");
        }

    }
}
