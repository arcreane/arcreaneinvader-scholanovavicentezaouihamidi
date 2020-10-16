using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Projectile 
    {
        public int Px;
        public int Py;
        private char m_apparenceProj = '|';
        public Projectile(int p_posx, int p_posy)
        {
            Px = p_posx;
            Py = p_posy+1;
        }

        public void UpdateProj()
        {
           
            if (Py < 30)
            {
                Py += 1;
                Console.SetCursorPosition(Px, Py);
                Console.Write(m_apparenceProj);
            }
            
            
        }
        public void ClearProj()
        {
            Console.SetCursorPosition(Px, Py-1);
        }
    }
}
