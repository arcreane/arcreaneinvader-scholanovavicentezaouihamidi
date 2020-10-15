using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Pawn : Ennemi
    {
        public Pawn()
        {
            m_ivie = 1;
        }

        internal static void ApparaitrePawn(Ennemi p_ivie)
        {
            Console.WriteLine("Je suis un pawn, j'ai " + p_ivie);
        }
    }
}
