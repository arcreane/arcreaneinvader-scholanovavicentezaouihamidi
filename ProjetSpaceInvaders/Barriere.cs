﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Barriere : Charactere
    {
        public Barriere()
        {
            m_iVie = 1;
            Console.WriteLine("Je suis une barriere, j'ai " + m_iVie);
        }
    }
}
