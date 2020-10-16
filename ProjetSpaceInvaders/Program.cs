using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class Program
    {
        static bool GameOver = false;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ElementsEspace NewGame = new ElementsEspace();


            while (!GameOver)
            {
                Thread.Sleep(250);
            }

            Console.ReadLine();
           


        }
    }
}
