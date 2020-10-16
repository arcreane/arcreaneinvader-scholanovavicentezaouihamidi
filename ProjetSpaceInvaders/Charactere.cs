using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSpaceInvaders
{
     public abstract class Charactere
    {
        protected int m_iVie;
        protected int x;
        protected int y;
        public Charactere()
        {
                
        }

        public abstract void ActionElement();
        
        
    }
}
