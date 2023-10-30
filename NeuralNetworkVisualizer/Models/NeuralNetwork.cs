public class NeuralNetwork
{
    public List<Layer> Layers { get; set; } = new List<Layer>();

    public void AddLayer(int neuronCount)
    {
        var layer = new Layer();
        for (int i = 0; i < neuronCount; i++)
        {
            layer.Neurons.Add(new Neuron { Id = i });
        }
        Layers.Add(layer);
    }
}
