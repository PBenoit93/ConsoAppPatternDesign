using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard.tools
{
    public class AlternanceCri : IComportementCancan
    {
        public IComportementCancan bruit1;
        public IComportementCancan bruit2;

        public AlternanceCri(IComportementCancan bruit1, IComportementCancan bruit2)
        {
            this.bruit1 = bruit1;
            this.bruit2 = bruit2;      
        }

        public bool first=true;

        public void cancan()
        {
            if (first)
            {
                bruit1.cancan();
                first = false;
            }
            else
            {
                bruit2.cancan();
                first = true;
            }
            
        }
    }
}
