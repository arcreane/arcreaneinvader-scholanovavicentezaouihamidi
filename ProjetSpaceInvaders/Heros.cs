using System;
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
            Console.SetCursorPosition(Posx, Posy);
            if (Posx < 0)
            {
                Posx = 0;
            }
            else
            {
                if (Posx > 119)
                {
                    Posx = 119;
                }
            }
            Console.SetCursorPosition(Posx, Posy);
            Console.Write(m_apparenceHeros);
        }
        public Projectile Tirer()
        {
            return new Projectile(Posx, Posy);

        }
    }
}
