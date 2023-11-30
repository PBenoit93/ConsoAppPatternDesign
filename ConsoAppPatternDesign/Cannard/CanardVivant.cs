using ConsoAppPatternDesign.Cannard.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoAppPatternDesign.Cannard
{
    public class CanardVivant: ICanard
    {
        public ICanard _canard;
        public int pointDeVie = 5;

        public CanardVivant(ICanard canard){
            _canard = canard;
        }
        public void afficher()
        {
            _canard.afficher();
            Console.WriteLine("----------------");
        }

        public void cancan()
        {
            _canard.cancan();
        }

        public int getVie() {
           return pointDeVie;
        }

        public void nager()
        {
            _canard.nager();
        }

        public void vol()
        {
            _canard.vol();
            pointDeVie--;
        }
    }
}
