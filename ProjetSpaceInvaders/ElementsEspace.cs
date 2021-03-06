﻿using Microsoft.Win32;
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
        Barriere m_barriere = new Barriere();
        List<Projectile> m_ListeBullet = new List<Projectile>();
        private Pawn[] m_Pawn;
        public ElementsEspace()
        {
            //Timer qui permet de géré les entré du joueur
            System.Timers.Timer TimerHero = new System.Timers.Timer();
            TimerHero.Elapsed += TimerHero_Elapsed;
            TimerHero.Interval = 50;
            TimerHero.Start();

            //Timer pour l'update affichage
            System.Timers.Timer TimerUpdate = new System.Timers.Timer();
            TimerUpdate.Elapsed += TimerUpdate_Elapsed; ;
            TimerUpdate.Interval = 40;
            TimerUpdate.Start();

            m_heros.ApparaitreHeros();
            //m_heros.ActionElement();
            m_Pawn = new Pawn[Program.NUMBER_PAWN];
            for (int i = 0; i < Program.NUMBER_PAWN; i++)
            {
                m_Pawn[i] = new Pawn(30 + (20 * (i / 8)), 10 + (i % 8));
                m_Pawn[i].ApparaitrePawn();
            }

        }
        
        //public ElementsEspace()
        //{
        //    Heros m_heros = new Heros();
           
        //    Barriere m_barriere = new Barriere();
        //    m_heros.ApparaitreHeros();
        //    m_heros.ActionElement();
        //}
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
                    m_ListeBullet.Add(m_heros.Tirer());
                    break;
            }
            
        }
        private void TimerUpdate_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Console.Clear();
            m_heros.ApparaitreHeros();
            foreach (var projectil in m_ListeBullet)
            {
                projectil.ClearProj();
                projectil.UpdateProj();
            }
        }
    }
}
