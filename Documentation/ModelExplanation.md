# Neural Network Model Explanation

The Neural Network Visualizer application provides an intuitive interface to design and visualize various neural network architectures. This document delves into the underlying data model.

## Core Components

1. **Neuron** : The basic computational unit of the network.

* **Properties** :
  * `Id`: A unique identifier.
  * `X`: Horizontal position for visualization.
  * `Y`: Vertical position for visualization.

1. **Layer** : Represents a collection of neurons.

* Contains a list of `Neuron` objects.

1. **NeuralNetwork** : The overarching structure containing multiple layers.

* Facilitates the addition of layers with a variable number of neurons.

The application's core revolves around these constructs, enabling flexible design and visualization of neural networks.
