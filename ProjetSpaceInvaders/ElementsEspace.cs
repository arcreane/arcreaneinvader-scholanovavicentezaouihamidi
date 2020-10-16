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
        
       

        public ElementsEspace()
        {
            Heros m_heros = new Heros();
            for (int i = 20; i < 100; i+=10)
            {
                for (int j = 10; j < 30; j+=5)
                {
                    Pawn m_pawn = new Pawn(i, j);
                    m_pawn.ApparaitrePawn();
                }
            }
            Barriere m_barriere = new Barriere();
            m_heros.ApparaitreHeros();
            m_heros.ActionElement();
        }
    }
}
