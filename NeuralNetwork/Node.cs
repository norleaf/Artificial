using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Network
    {

        public double Sigmoid(double z)
        {
            //todo: figure out if this can handle vectors or arrays...
            return 1 / (1 + Math.Exp(-z));
        }

        public double FeedForward(Node node)
        {
            //todo: Figure out how to create this...
            /*
                    def feedforward(self, a):
                    """Return the output of the network if "a" is input."""
                    for b, w in zip(self.biases, self.weights):
                        a = sigmoid(np.dot(w, a)+b)
                    return a
             */
            return 0;
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

    }

    public class Node
    {
    }

    public class Image : ITrainingDataObject
    {
        public string label { get; set; }
    }

}
