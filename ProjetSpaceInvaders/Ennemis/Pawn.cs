using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjetSpaceInvaders
{
    class Pawn : Charactere
    {
        private string m_apparencePawn = "*";
        public Pawn(int u,int v)
        {
            m_iVie = 1;
            x = u;
            y = v;
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 1500;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DeplacerPawn();
            ApparaitrePawn();
        }

    public override void ActionElement()
        {
            throw new NotImplementedException();
        }

        public void ApparaitrePawn()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(m_apparencePawn);
        }

        public void DeplacerPawn()
        {
            Console.WriteLine(" ");
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");


            x -= 4;

            if (x < 0)
            {
                x = 0;
            }
            else
            {
                if (x > 120)
                {
                    x = 0;
                }
            }
        }
    }
}
