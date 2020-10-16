﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjetSpaceInvaders
{
    
    class Heros : Charactere
    {
        private char m_apparenceHeros = '$';
        public Heros()
        {
            m_iVie = 3;
            Posx = 20;
            Posy = 0;
        }


        public void ApparaitreHeros()
        {
            Console.SetCursorPosition(Posx,Posy);
            Console.Write(m_apparenceHeros);
        }

    }
}
