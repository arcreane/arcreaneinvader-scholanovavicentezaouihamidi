﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Barriere : Charactere
    {
<<<<<<< HEAD
        private char m_apparenceBarriere = 'H';
=======
        private char m_apparenceBarriere = '*';
>>>>>>> origin/main
        public Barriere()
        {
            m_iVie = 1;
            Console.SetCursorPosition(30, 10);
            Console.Write(m_apparenceBarriere);
            //Console.WriteLine("Je suis une barriere, j'ai " + m_iVie);
        }

        public override void ActionElement()
        {
            throw new NotImplementedException();
        }
    }
}
