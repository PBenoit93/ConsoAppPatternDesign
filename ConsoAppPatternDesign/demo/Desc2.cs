using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoAppPatternDesign.demo
{
    public class Desc2
    {
        private int multi = 0;
        private Ancetre ancetre = new Ancetre();

        public Desc2(int multi)
        {
            this.multi = multi;
        }

        public void affiche()
        {
            Console.WriteLine(multi * getCpt());
        }

        public int getCpt()
        {
            return ancetre.getCpt();
        }
    }
}
