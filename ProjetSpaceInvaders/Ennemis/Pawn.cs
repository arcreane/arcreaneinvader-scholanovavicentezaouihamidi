using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Pawn : Charactere
    {
        private char m_apparencePawn = '+';
        public Pawn()
        {
            m_iVie = 1;
            Console.SetCursorPosition(30, 20);
            Console.Write(m_apparencePawn);
            //Console.WriteLine("Je suis un pawn, j'ai " + m_iVie);
        }

        public override void ActionElement()
        {
            throw new NotImplementedException();
        }
    }
}
