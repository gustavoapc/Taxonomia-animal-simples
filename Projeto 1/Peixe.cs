using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    public abstract class Peixe : Animal
    {
        public abstract Boolean PossuiNadadeiras();
        public abstract void RespirarEmBaixoDaAgua();
        public abstract Boolean PossuiEscamas();
        public abstract void Nadar();

    }
}
