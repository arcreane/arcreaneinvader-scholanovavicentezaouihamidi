﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Pawn : Charactere
    {
        public Pawn()
        {
            m_iVie = 1;
            Console.WriteLine("Je suis un pawn, j'ai " + m_iVie);
        }

    }
}
