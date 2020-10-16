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
<<<<<<< HEAD
=======
        
       
>>>>>>> origin/main

        private Pawn[] m_Pawn;
        public ElementsEspace()
        {
            Heros m_heros = new Heros();
<<<<<<< HEAD
            m_Pawn = new Pawn[Program.NUMBER_PAWN];
            for (int i = 0; i < Program.NUMBER_PAWN; i++)
            {
                m_Pawn[i] = new Pawn(30+(20*(i/8)),10+(i%8));
                m_Pawn[i].ApparaitrePawn();
            }
            Barriere m_barriere = new Barriere();
            m_heros.ApparaitreHeros();
            m_heros.ActionElement();
        }
=======
            Pawn m_pawn = new Pawn();
            Barriere m_barriere = new Barriere();
            m_heros.ApparaitreHeros();
            m_heros.ActionElement();

        }


        
>>>>>>> origin/main
    }
}
