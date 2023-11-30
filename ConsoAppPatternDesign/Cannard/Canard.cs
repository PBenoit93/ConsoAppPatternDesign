using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoAppPatternDesign.Cannard.interfaces;

namespace ConsoAppPatternDesign.Cannard
{
    public abstract class Canard: ICanard
    {
        protected IComportementVol comportementVol;
        protected IComportementCancan comportementCancan;
    
        public void nager()
        {
            Console.WriteLine("nage");
        }
        public abstract void afficher();

        public void vol() { 
            
            comportementVol.voler();

        }

        public void cancan() {

            comportementCancan.cancan();

        }

        public IComportementCancan getCancan()
        {
            return comportementCancan;
        }

        public void setVol(IComportementVol comportementVol) {
            this.comportementVol = comportementVol;
        }

        public void setCancan(IComportementCancan comportementCancan)
        {
            this.comportementCancan = comportementCancan;
        }


    }
}
