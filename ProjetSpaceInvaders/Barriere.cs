using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Barriere : ElementsEspace
    {
        public Barriere()
        {
            m_ivie = 1;
        }

        public void ApparaitreBarriere()
        {
            Console.WriteLine("Je suis une barriere, j'ai " + m_ivie);
        }
    }
}
