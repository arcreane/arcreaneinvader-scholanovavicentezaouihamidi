using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Afficheur
    {
        private Pawn[] m_Pawn;
        private Heros m_heros;
        public Afficheur()
        {
            ElementsEspace NewGame = new ElementsEspace();
            for (int i = 0; i < Program.NUMBER_PAWN; i++)
            {
                m_Pawn[i].ApparaitrePawn();
            }
            m_heros.ApparaitreHeros();
        }
    }
}
