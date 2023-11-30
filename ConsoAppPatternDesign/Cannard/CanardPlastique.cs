using ConsoAppPatternDesign.Cannard.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class CanardPlastique : Canard
    {
        public CanardPlastique()
        {
            comportementVol = new SaitPasVoler();
            comportementCancan = new Muet();
        }

        public override void afficher()
        {
            Console.WriteLine("c'est un cannard en plastique");
        }

    }
}
