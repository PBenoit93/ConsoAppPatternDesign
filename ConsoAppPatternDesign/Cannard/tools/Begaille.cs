using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard.tools
{
    public class Begaille : IComportementCancan
    {
        public IComportementCancan bruit;

        public Begaille(IComportementCancan bruit)
        {
            this.bruit = bruit;
        }

        public void cancan()
        {
            bruit.cancan();
            bruit.cancan();
        }
    }
}
