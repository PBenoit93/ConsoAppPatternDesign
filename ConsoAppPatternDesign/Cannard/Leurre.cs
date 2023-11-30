using ConsoAppPatternDesign.Cannard.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class Leurre : Canard
    {
        public Leurre()
        {
            comportementVol = new SaitPasVoler();
            comportementCancan = new CoinCoin();
        }

        public override void afficher()
        {
            Console.WriteLine("c'est un leurre");
        }

    }
}
