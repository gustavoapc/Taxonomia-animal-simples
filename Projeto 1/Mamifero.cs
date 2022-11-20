using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    public abstract class Mamifero : Animal
    {
        public Mamifero() 
        {
            
        }
        public abstract void Mamar();



        public abstract Boolean PossuiDiafragma();


        public abstract Boolean Pelos();
        

        
    
    }
}
