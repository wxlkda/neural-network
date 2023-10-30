namespace NeuralNetworkVisualizer.ML
{
    using Microsoft.ML;
    using NeuralNetworkVisualizer.Data;
    using System;

    public class NeuralNetworkModel
    {
        public void TrainAndEvaluate()
        {
            var context = new MLContext();
            var data = context.Data.LoadFromTextFile<InputData>("path_to_fashion_mnist.csv", separatorChar: ',');

            var pipeline = context.Transforms.Conversion.MapValueToKey("Label")
                .Append(context.Transforms.Concatenate("Features", "PixelValues"))
                .Append(context.Transforms.NormalizeMinMax("Features"))
                .Append(context.BinaryClassification.Trainers.LbfgsLogisticRegression(labelColumnName: "Label", featureColumnName: "Features"))
                .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(data);

            // Prediction
            var predictionEngine = context.Model.CreatePredictionEngine<InputData, OutputData>(model);
            var sampleData = new InputData { PixelValues = new float[784] };  // Replace with actual pixel data
            var result = predictionEngine.Predict(sampleData);
            Console.WriteLine($"Predicted category: {result.Prediction}");

            // Evaluation
            var predictions = model.Transform(data);
            var metrics = context.BinaryClassification.Evaluate(predictions, "Label");
            Console.WriteLine($"Accuracy: {metrics.Accuracy}");
        }

        public class OutputData
        {
            [ColumnName("PredictedLabel")]
            public float Prediction;
        }
    }
}
