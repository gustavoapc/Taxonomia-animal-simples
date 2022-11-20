using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    public abstract class Ave: Animal
    {
        public Ave()
        {

        }

        public abstract Boolean PossuiAsas();

        public abstract void Piar();

        public abstract Boolean PossuiBico();
        
        public abstract void Voar();

        public abstract Boolean PossuiPenas();
    }
}
