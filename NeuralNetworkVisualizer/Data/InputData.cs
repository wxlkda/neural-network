namespace NeuralNetworkVisualizer.Data
{
    using Microsoft.ML.Data;

    public class InputData
    {
        [VectorType(784)]
        public float[] PixelValues { get; set; }
        public float Label { get; set; }
    }
}
