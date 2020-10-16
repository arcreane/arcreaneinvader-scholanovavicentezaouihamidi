using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
    class ElementsEspace
    {
        
        public ElementsEspace()
        {
            
            Heros m_heros = new Heros();
            Pawn m_pawn = new Pawn();
            Barriere m_barriere = new Barriere();
            Projectile m_projectile = new Projectile();
            m_heros.ApparaitreHeros();
            m_heros.ActionElement();

        }


        
    }
}
