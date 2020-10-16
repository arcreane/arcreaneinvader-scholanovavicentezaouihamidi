using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjetSpaceInvaders
{
    class Projectile : Charactere
    {
        private char apparence_Projectile = '|';
        private int x;
        private int y;
       public Projectile()
        {
           
            Timer timerProjectile = new Timer();
            timerProjectile.Elapsed += Timer_Elapsed;
            timerProjectile.Interval = 250;
            timerProjectile.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ConsoleKey touche = Console.ReadKey().Key;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");

            switch (touche)
            {
                case ConsoleKey.Spacebar:
                    y = y + 1;
                    break;    
            }

            ApparaitreProjectile();
        }

        public void ApparaitreProjectile()
        {     
            Console.SetCursorPosition(x, y);
            Console.Write(apparence_Projectile);
        }

        public override void ActionElement()
        {
            throw new NotImplementedException();
        }
    }
}



