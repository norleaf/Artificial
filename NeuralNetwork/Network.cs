using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Network
    {

        public List<Layer> Layers { get; set; }

        public Network(int inputs, int outputs, params Layer[] layers)
        {
            var intputLayer = new Layer();
        }

        public float Sigmoid(float z)
        {
            //todo: figure out if this can handle vectors or arrays...
            return (float)( 1 / (1 + Math.Exp(-z)));
        }

        public void FeedForward(Node node)
        {
            // Figure out how to create this...
            /*
                    def feedforward(self, a):
                    """Return the output of the network if "a" is input."""
                    for b, w in zip(self.biases, self.weights):
                        a = sigmoid(np.dot(w, a)+b)
                    return a
             */
             //THink this might be it
            var charge = node.Inputs.Sum(r => r.Charge * r.Weight) + node.Bias;
            var sigmoidedCharge = Sigmoid(charge);
            node.Outputs.ForEach(r => r.Charge = sigmoidedCharge);
        }

        public void SGD(ITrainingDataObject[] trainingData, int epochs, int batchSize, double eta, ITrainingDataObject[] testData = null)
        {
                        /*todo: Train the neural network using mini-batch stochastic
                    gradient descent.  The "training_data" is a list of tuples
                    "(x, y)" representing the training inputs and the desired
                    outputs.  The other non-optional parameters are
                    self-explanatory.  If "test_data" is provided then the
                    network will be evaluated against the test data after each
                    epoch, and partial progress printed out.  This is useful for
                    tracking progress, but slows things down substantially."""
                    */
        }
    }

    

    public class Layer
    {
        public List<Node> Nodes { get; set; }
    }

    public class Node
    {
        public float Bias { get; set; }
        public List<Neuron> Inputs { get; set; }
        public List<Neuron> Outputs { get; set; }
    }

    public class Neuron
    {
        public float Weight { get; set; }
        public float Charge { get; set; }
    }

    public class Image : ITrainingDataObject
    {
        public string label { get; set; }
    }

}
