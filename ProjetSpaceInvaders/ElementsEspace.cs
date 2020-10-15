using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class ElementsEspace
    {
       
        protected int x;
        protected int y;
       

        public ElementsEspace()
        {
            ElementsEspace m_heros = new Heros();
            ElementsEspace m_pawn = new Pawn();
            ElementsEspace m_barriere = new Barriere();

        }
        
    }
}
