using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLayerPerceptron
{
    class Neuron
    {
        public double[] inputs;
        public double[] weights;
        public double[] final = new double[] { 0, 0, 0};

        public Neuron( double[] inputs, double[] weights)
        {

            
            this.inputs = inputs;
            this.weights = weights;

        }

        public void WeightedInputs()
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = inputs[i] * weights[i];
                //if (inputs[i] > 1)
                //{
                //    final[i] = 1;
                //}
                //else
                //{
                //    final[i] = 0;
                //}
            }
        }

        public void WeightAdjustment()
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                double result = 1.001 * inputs[i] * final[i];
                weights[i] -= result;
            }
        }

       

    }
}
