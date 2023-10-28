# Neural Network Visualizer in WPF

## Overview

"WPF tool for real-time neural network design and visualization. Combines deep learning concepts with user-friendly design."

## Data Model

### Neuron

```csharp
public class Neuron
{
    public int Id { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
}
```

Each **Neuron** serves as a computational unit, processing data through an activation function to produce an output.

### Layer

```csharp
public class Layer
{
    public List<Neuron> Neurons { get; set; } = new List<Neuron>();
}
```

The **Layer** contains a collection of neurons, facilitating structured building of neural networks.

## Model Implementation

To represent a neural network, we maintain a list of layers. Each layer can have a variable number of neurons.

```csharp
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
```

With this structure, adding a layer with a specific number of neurons becomes straightforward. You can further extend this to include methods for removing layers, connecting neurons, or simulating data flow.

## Functionalities

- **Design and Customize**: Architect neural networks with diverse layers and neurons.
- **Visualize in Real-time**: Experience dynamic graphical feedback.
- **Informational Overlays**: Access a rich database of neural network insights.
- **Save and Load Architectures**: Store and retrieve neural designs efficiently.
