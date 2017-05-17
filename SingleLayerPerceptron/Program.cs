using System;

namespace SingleLayerPerceptron
{
    class Program
    {
        static void Main(string[] args)
        {

            bool error = true;
            double[] expected = new double[] { 1, 4, 2 };

            Neuron neuron1 = new Neuron(new double[] { 0.3, 0.5, 0.4}, new double[] { 0.7, 0.8, 0.9 });
            Neuron neuron2 = new Neuron(new double[] { 0.36, 0.7, 0.5 }, new double[] { 0.1, 0.2, 0.05 });

            while (error)
            {
                error = false;

                Console.WriteLine("----------------------NEURON1---------------------");
                Console.WriteLine("I " + neuron1.inputs[0] + " " + neuron1.inputs[1] + " " + neuron1.inputs[2]);
                Console.WriteLine("I " + neuron1.weights[0] + " " + neuron1.weights[1] + " " + neuron1.weights[2]);
                Console.WriteLine("----------------------NEURON1---------------------");

                Console.WriteLine("----------------------NEURON2---------------------");
                Console.WriteLine("I " + neuron2.inputs[0] +" "+ neuron2.inputs[1] + " " + neuron2.inputs[2]);
                Console.WriteLine("I " + neuron2.weights[0] + " " + neuron2.weights[1] + " " + neuron2.weights[2]);
                Console.WriteLine("----------------------NEURON2---------------------");

                
                //do it for the first time when running the neuron
                neuron1.WeightedInputs();
                neuron2.WeightedInputs();

                for (int i = 0; i < expected.Length; i++)
                {
                    if (!Convert.ToInt32(neuron1.inputs[i]).Equals(expected[i]))
                    {
                        double result = 1.0001 * neuron1.inputs[i] * neuron1.final[i];
                        neuron1.weights[i] += result;
                        error = true;
                    }
                    if (!Convert.ToInt32(neuron2.inputs[i]).Equals(expected[i]))
                    {
                        double result = 1.0001 * neuron1.inputs[i] * neuron1.final[i];
                        neuron1.weights[i] += result;
                        error = true;
                    }
                }

                

                Console.Read();


            }


        }
    }
}