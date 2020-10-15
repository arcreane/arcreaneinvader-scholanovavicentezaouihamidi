using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Heros : Charactere
    {
        public Heros(){
            m_iVie = 3;
            Console.WriteLine("Je suis le Heros et j'ai " + m_iVie + " point de vie ");
        }



    }
}
