using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    public abstract class Animal
    {

        public Animal()
        {

        }
        public  string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string NomeCientifico { get; set; }
        public  string Habitat { get; set; }

        public abstract void Respirar();

        public abstract void SeAlimentar();

        public abstract void SeLocomover();
        public abstract void Reproduzir();
        

       }
    
    }

