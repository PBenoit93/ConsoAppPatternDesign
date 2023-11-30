using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class CanardAdapter : IAnimal
    {
        public ICanard canard;
        public CanardAdapter(ICanard canard) {
            this.canard = canard;
        }
        public void crier()
        {
            canard.cancan();
        }

        public void fuir()
        {
            canard.vol();
        }
    }
}
