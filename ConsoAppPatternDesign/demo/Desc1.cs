using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.demo
{
    public class Desc1
    {
        private string name = "";

        private Ancetre ancetre = new Ancetre();


        public Desc1(string name)
        {
            this.name = name;
        }

        public void affiche()
        {
            Console.WriteLine(name + ancetre.getCpt());
        }
    }
}
