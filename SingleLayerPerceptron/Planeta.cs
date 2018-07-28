using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLayerPerceptron
{
    class Planeta
    {

        public Planeta()
        {

        
        }

        //Valores devem ser 1 ou 0, presente ou não; 
        public int A;
        public int B;
        public int C;
        public int D1;
        public int D2;
        public int E;
        public int F;
        public int G;
        public int H;
        public int K;
        //Distancia deve ser em anos luz;
        public double Distancia;
        //Tamanho deve ser em KM de circunferencia
        public double Tamanho;


        //Comprimento de onda
        public readonly double Anm = 759.37;
        public readonly double Bnm = 686.72;
        public readonly double Cnm = 656.28;
        public readonly double D1nm = 589.59;
        public readonly double D2nm = 589;
        public readonly double Enm = 526.96;
        public readonly double Fnm = 486.13;
        public readonly double Gnm = 431.32;
        public readonly double Hnm = 396.85;
        public readonly double Knm = 393.37;



        public bool setPresent( double comprimento )
        {
            if (Anm.Equals(comprimento))
            {
                A = 1;
                return true;
            }
            if (Bnm.Equals(comprimento))
            {
                B = 1;
                return true;
            }
            if (Cnm.Equals(comprimento))
            {
                C = 1;
                return true;
            }
            if (D1nm.Equals(comprimento))
            {
                D1 = 1;
                return true;
            }
            if (D2nm.Equals(comprimento))
            {
                D2 = 1;
                return true;
            }
            if (Enm.Equals(comprimento))
            {
                E = 1;
                return true;
            }
            if (Fnm.Equals(comprimento))
            {
                F = 1;
                return true;
            }
            if (Gnm.Equals(comprimento))
            {
                G = 1;
                return true;
            }
            if (Hnm.Equals(comprimento))
            {
                H = 1;
                return true;
            }
            if (Knm.Equals(comprimento))
            {
                K = 1;
                return true;
            }
            return false;
        }

    }
}
