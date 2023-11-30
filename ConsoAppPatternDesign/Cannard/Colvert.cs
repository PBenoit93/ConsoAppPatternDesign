using ConsoAppPatternDesign.Cannard.interfaces;
using ConsoAppPatternDesign.Cannard.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class Colvert : Canard
    {
        public Colvert() {
            comportementVol = new VolAvecAiles();
            comportementCancan= new CoinCoin();
        }

        public override void afficher()
        {
            Console.WriteLine("c'est un colvert");
        }

    }
}
