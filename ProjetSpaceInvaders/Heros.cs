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
        public Heros(){
            m_iVie = 3;
            x = 20;
            y = 0;
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 250;
            timer.Start();

            //Console.WriteLine("Je suis le Heros et j'ai " + m_iVie + " point de vie ");

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ConsoleKey touche = Console.ReadKey().Key;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");

            switch (touche)
            {
                //case ConsoleKey.Spacebar:
                //break;
                case ConsoleKey.LeftArrow:
                    x = x - 10;
                    break;
                case ConsoleKey.RightArrow:
                    x = x + 10;
                    break;
            }

            ApparaitreHeros();
        }

        public void ApparaitreHeros()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(m_apparenceHeros);
        }

        public override void ActionElement()
        {

        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }





    }
}
