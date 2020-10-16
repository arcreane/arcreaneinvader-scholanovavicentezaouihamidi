using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ProjetSpaceInvaders
{
   public class ElementsEspace
    {
        Heros m_heros = new Heros();
        Pawn m_pawn = new Pawn();
        Barriere m_barriere = new Barriere();
        List<Projectile> projectil  = new List<Projectile>();
        public ElementsEspace()
        {
            //Timer qui permet de géré les entré du joueur
            System.Timers.Timer TimerHero = new System.Timers.Timer();
            TimerHero.Elapsed += TimerHero_Elapsed;
            TimerHero.Interval = 40;
            TimerHero.Start();
            // Timer pour l'update affichage
            //System.Timers.Timer TimerUpdate = new System.Timers.Timer();
            //TimerUpdate.Elapsed += TimerHero_Elapsed;
            //TimerUpdate.Interval = 50;
            //TimerUpdate.Start();

            m_heros.ApparaitreHeros();
            //m_heros.ActionElement();

        }

        private void TimerHero_Elapsed(object sender, ElapsedEventArgs e)
        {
            ConsoleKey touche = Console.ReadKey().Key;
            Console.SetCursorPosition(m_heros.Posx,m_heros.Posy);
            Console.WriteLine(" ");

            switch (touche)
            {
                //case ConsoleKey.Spacebar:
                //break;
                case ConsoleKey.LeftArrow:
                    m_heros.Posx -= 10;
                    break;
                case ConsoleKey.RightArrow:
                    m_heros.Posx += 10;
                    break;
                case ConsoleKey.Spacebar:
                    projectil = new List<Projectile>();
                    break;
            }

            m_heros.ApparaitreHeros();
        }
    }
}
