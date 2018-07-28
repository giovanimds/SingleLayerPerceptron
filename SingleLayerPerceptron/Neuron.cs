using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLayerPerceptron
{
    class Neuron
    {
        
        Planeta planeta;
        //                                       A    B    C    D1   D2   E    F    G    H    K    Dist Tam
        private double[] weight = new double[] { 0.3, 0.3, 0.3, 0.5, 0.5, 0.7, 0.3, 0.7, 0.7, 0.7, 0.6, 0.7 };

        public Neuron( Planeta planeta )
        {
            this.planeta = planeta;

        }
        

        public int Try()
        {
            

            return 0;
        }
       

    }
}
