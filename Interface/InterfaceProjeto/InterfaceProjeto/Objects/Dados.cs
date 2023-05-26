using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Objects
{
    internal class Dados
    {
        public float Peso;
        public float PMax;
        public float Tempo;
        public float Calibracao;

        public float peso
        {
            get { return Peso; }
            set { Peso = value; }
        }

        public float pmax
        {
            get { return PMax; }
            set { PMax = value; }
        }

        public float tempo
        {
            get { return Tempo; }
            set { Tempo = value; }
        }

        public float calibracao
        {
            get { return Calibracao; }
            set { Calibracao = value; }
        }
    }
}
