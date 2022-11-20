using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    internal class Tubarão : Peixe
    {
        public override void Nadar()
        {
            throw new NotImplementedException();
        }

        public Boolean PossuemEscamasPlacoides()
        {
            return true;
        }
        public override bool PossuiEscamas()
        {
            return true;
        }

        public override bool PossuiNadadeiras()
        {
            return true;
        }

        public override void Reproduzir()
        {
            throw new NotImplementedException();
        }

        public override void Respirar()
        {
            throw new NotImplementedException();
        }

        public override void RespirarEmBaixoDaAgua()
        {
            throw new NotImplementedException();
        }

        public override void SeAlimentar()
        {
            throw new NotImplementedException();
        }

        public override void SeLocomover()
        {
            throw new NotImplementedException();
        }
    }
}
