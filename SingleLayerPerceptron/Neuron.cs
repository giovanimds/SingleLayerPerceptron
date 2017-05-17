using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLayerPerceptron
{
    class Neuron
    {

        double[] expected;
        double[] inputs;
        double[] weights;
        double[] final;
        double threshold;
        int output;

        public Neuron(double[] expected, double[] inputs, double[] weights)
        {

            this.expected = expected;
            this.inputs = inputs;
            this.weights = weights;

        }

        public void WeightedInputs()
        {
            for (int i = 0; i <= inputs.Length; i++)
            {
                inputs[i] = inputs[i] * weights[i];
                if (inputs[i] > 1)
                {
                    final[i] = 1;
                }
                else
                {
                    final[i] = 0;
                }
            }
        }

        public void WeightAdjustment()
        {
            for (int i = 0; i <= inputs.Length; i++)
            {
                double result = 0.01 * inputs[i] * final[i];
                weights[i] += result;
            }
        }



    }
}
