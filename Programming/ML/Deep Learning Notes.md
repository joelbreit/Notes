# Deep Learning

Flashcards should work both ways
- Term -> Definition as well as Definition -> Term
- The definition should never use the entire term and should try to avoid using part of the term
- The definition should be concise
  - Instead of "using domain knowledge and expertise..." use "using domain knowledge"
  - Instead of "a type of machine learning where the system..." use "ML technique that"
- The definition should not be too abstract
  - Instaed of "a structured representation of the meaning of a word or phrase" use "a set of words that denote aspects of a particular type of event like a commercial transaction"
- Don't list synonyms unnecessarily


## Machine Learning

1.  **entropy**: A measure of the uncertainty or disorder in a system
2.  **intuitive interpretation of entropy**: The lower bound on the number of bits it would take to encode a certain decision or piece of information in the optimal coding scheme
3.  **Stationary Distribution**: A probability distribution that remains unchanged by a given process over time
4.  **Cross-Entropy**: A measure of the difference between two probability distributions
5.  **Smoothing**: A technique used to assign non-zero probabilities to unseen events in a prediction model
6.  **Sampling**: Selecting from a predicted distribution to generate content with a prediction model
7.  **Dev Set**: A dataset used to tune hyperparameters and evaluate the model during training
8.  **Markov Assumption**: The simplifying assumption that the future state of a system depends only on the current state
9.  **representation learning**: ML technique where the system automatically discovers the features or representations needed for a task from the raw data instead of manually crafting features
10. **feature engineering**: ML process that uses domain knowledge to identify the most relevant aspects of the data
11. **n-fold cross-validation**: technique for evaluating the performance of a model by dividing the data into n subsets and training the model n times, each time using a different subset as the test set

## Neural Networks

1.  **Tensor**: A multi-dimensional array of numerical values, used to represent data and model parameters in deep learning.
2.  **Bias**: A term added to a neural network model to adjust its output, allowing for more flexibility and better performance.
3.  **Neural Network**: A computational model inspired by the human brain consisting of interconnected nodes or neurons used to process and learn from data.
4.  **Activation Function**: A function applied to the output of a neuron in a neural network, adding non-linearity
5.  **Batch Training**: A training method that involves processing a set of training examples in parallel, often leading to faster convergence and more stable training.
6.  **Online Training**: A training method where a model is updated incrementally, as new data points are received, without the need for the entire dataset.
7.  **Epoch**: A complete iteration through the entire training dataset during neural network training.
8.  **Vector**: A one-dimensional array of numerical values, representing a point in a multi-dimensional space.
9.  **Scalar**: A single numerical value, used to represent magnitude.
10. **Deep Learning**: A subfield of machine learning focused on neural networks with multiple layers, enabling the learning of complex patterns and representations.
11. **Partial Derivative**: The rate of change of a function with respect to one variable, while holding the other variables constant.
12. **Gradient**: A vector representing the direction and magnitude of the steepest increase in a multivariable function, used in optimization.
13. **Stochastic Gradient Descent (SGD)**: An optimization algorithm that updates model parameters iteratively, using a randomly selected subset of the training data rather than the whole set.
14. **Binary Step Activation Function**: An activation function that outputs a 0 or 1 based on whether the input is below or above a threshold.
15. **Linear/Identity Activation Function**: An activation function that returns the input unchanged.
16. **Sigmoid Activation Function**: An activation function that maps input values to a range between 0 and 1, with an S-shaped curve.
17. **Hyperbolic Tangent (Tanh) Activation Function**: An activation function that maps input values to a range between -1 and 1, with a steeper slope than the sigmoid function.
18. **Rectified Linear Unit (ReLU) Activation Function**: An activation function that outputs the input value if it's positive and 0 otherwise
19. **Leaky ReLU Activation Function**: A variant of the ReLU activation function that allows for a small, positive gradient when the input is negative, addressing the dying ReLU problem.
20. **Softmax Activation Function**: An activation function that normalizes the output of a neural network to a probability distribution over predicted output classes, usually used in the output layer of a classifier.
21. **Derivative of Binary Step Function**: The derivative that is undefined at the point of discontinuity (the threshold) and zero everywhere else.
22. **Derivative of Linear Function**: f’(x) = the slope of x
23. **Derivative of the Sigmoid Function**: f’(x) = f(x) * (1 - f(x))
24. **Derivative of Tanh Function**: f’(x) = 1 - f(x)^2
25. **Derivative of ReLU Function**: The derivative that is 1 for positive inputs and 0 for negative inputs.
26. **Derivative of Leaky ReLU Function**: f’(x) = 1 for positive input and a small value (the leak parameter) for negative input
27. **Overfitting**: A modeling error that occurs when a function is too closely fit to a limited set of data points and performs poorly on unseen data.
28. **Underfitting**: A modeling error that occurs when a function is not complex enough to capture the underlying pattern of the data, leading to poor performance on both training and testing data.
29. **Regularization**: The process of changing results to be simpler in order to avoid overfitting.
30. **Dropout**: A regularization technique for neural networks that involves randomly setting a fraction of weights to 0 during training time.
31. **Convolutional Neural Network (CNN)**: A type of deep learning model particularly effective for image analysis tasks, where neurons in a layer are connected to only a small region of the layer before it, mirroring the receptive fields of neurons in the human visual cortex.
32. **Loss Function**: A function that calculates the difference between the predicted output and the actual output of a model, guiding the optimization of the model parameters.
33. **Gradient Descent**: An optimization algorithm used to minimize the loss function by iteratively adjusting the parameters in the direction of steepest descent.
34. **Learning Rate**: A hyperparameter that determines the step size during the gradient descent, affecting the speed and quality of learning.
35. **Momentum**: A technique used in gradient descent to accelerate learning by taking into account previous gradients to influence the current one.
36. **Batch Normalization**: A technique used to make a network more stable through adjusting of each layers' inputs by re-centering and re-scaling (i.e. fixing the mean and variance).
37. **One-Hot Encoding**: A process of converting categorical data into a binary vector representation where each category is represented by a vector that contains a one in the index corresponding to the category and zero in all other indices.
38. **Transfer Learning**: A machine learning method where a pre-trained model is used as a starting point for a similar task.
39. **Data Augmentation**: Techniques used to increase the diversity of your training data by applying random (but realistic) transformations such as rotations, shifts, and flips.
40. **Cross-Validation**: A technique for evaluating and comparing machine learning models by dividing data into two segments: one used to learn or train a model and the other used to validate the model.
41. **Precision (or Positive Predictive Value)**: The fraction of true positives to the total number of (correct or incorrect) positive predictions.
42. **Recall (or Sensitivity)**: The fraction of true positives to the total number that should have been identified as positive.
43. **F1 Score**: The harmonic mean of precision and recall, providing a single score that balances both the concerns of precision and recall in one number and prioritizes the balance between them.
44. **Decision Tree**: A type of model in machine learning which uses a tree-like graph of decisions to make predictions.
45. **Random Forest**: An ensemble learning method that constructs multiple decision trees during training and uses the mode or mean of the trees for the output.
46. **Bootstrap Aggregating (Bagging)**: Machine learning technique that creates multiple sets of data from the original dataset then trains a separate decision tree on each dataset.
47. **Boosting**: A machine learning technique where a model is trained repeatedly and mistakes in past iterations are given more weight in subsequent runs to create a better model.
48. **Principal Component Analysis (PCA)**: A dimensionality reduction technique that transforms a number of possibly correlated variables into a smaller number of uncorrelated variables.
49. **t-Distributed Stochastic Neighbor Embedding (t-SNE)**: A machine learning algorithm for visualization and dimensionality reduction. It is particularly well-suited for the visualization of high-dimensional datasets.
50. **K-Nearest Neighbors (K-NN)**: A machine learning technique in which predictions are based on the closest training examples in the data set.
51. **K-Means Clustering**: An unsupervised machine learning algorithm that groups data into K number of clusters based on the mean distance from the centroid created for each cluster.
52. **Hierarchical Clustering**: An algorithm that groups similar objects into groups called clusters. It builds a hierarchy of clusters by repeatedly applying a chosen clustering procedure.
53. **Autoencoder**: A type of artificial neural network used for learning efficient codings of input data. Typically used for the purpose of dimensionality reduction or denoising.
54. **Generative Adversarial Network (GAN)**: A class of machine learning frameworks designed to generate new, synthetic data that can pass as original data. It consists of two parts: a generator network and a discriminator network.
55. **Backpropagation**: An algorithm used in training neural networks, involving propagating the errors backward through the network. Weights and biases are adjusted in order to minimize the error.
56. **Feed Forward Neural Networks**: A type of Artificial Neural Network where connections between the units do not form a cycle.
57. **Unsupervised Pre-trained Networks**: A type of Neural Network that is first trained with unsupervised learning (without labeled data) and then fine-tuned with supervised learning (with labeled data).
58. **Gradient Clipping**: A technique to prevent exploding gradients in a neural network by setting a threshold and scaling down gradients when the threshold is exceeded.

### October 23rd

1. **Weight Initialization**: The process of pre-setting parameter values in a neural network before training which can help speed up convergence and can help avoid vanishing/exploding gradients
2.  **Probabolistic Normalization**: Dividing by some total count so that the results fall between 0 and 1 and sum to 1
3.  **Chain Rule of Probability**: The probability of multiple events cooccurring is the product of the probabilities of each event occurring
4.  **Maximum Likelihood Estimation (MLE)**: Statistical method for optimizing the parameters of a model by maximizing the likelihood of the observed data
5.  **Relative Frequency**: The number of times an event occurs divided by the total number of events
6.  **Extrinsic Evaluation**: Evaluating an improvement in a system by its effect on the final performance of the desired task
7.  **Perplexity**: A measure of how confused a prediction model is by real data that ranges from 1 to ∞ where 1 is perfect/correct confidence in every prediction, 4 is an average confidence of 1/4, etc.
8.  **Underflow**: When a number is too small to be represented in a computer's memory often caused by multiplying many probabilities together
9.  **Vanishing/Exploding Gradient Problem**: When the gradients in a deep neural network become too small or too large, making learning difficult
10. **Retrieval Augmented Generation (RAG)**: A model that combines relevant context from a knowledge base with input to produce better output
11. **Circuit**: A path or series of connections in a neural network contributing to its ability to perform tasks such as pattern recognition or classification

## Logistic Regression

1. **logistic regression**: a statistical model used to predict the probability of a binary outcome based on one or more predictor variables
2. **discriminative classifier**: a type of classifier that models the decision boundary between classes directly
3. **generative classifier**: a type of classifier that models the distribution of each class and the distribution of the features given the class
4. **Bayes' Theorem**: a mathematical formula for determining the conditional probability of an event based on prior knowledge of conditions that might be related to the event
5. **Bayes' Theorem formula**: P(H|E) = P(E|H) * P(H) / P(E) i.e. the probability of a hypothesis given evidence (posterior) is proportional to the probability of the evidence given the hypothesis (likelihood) times the probability of the hypothesis (prior) divided by the probability of the evidence (normalizing constant)
6. **multinomial logistic regression**: a logistic regression model that is used when the dependent variable is nominal with more than two levels
7. **naive Bayes**: a simple probabilistic classifier with a strong assumption of independence between features
8. **softmax function**: a function that takes an input vector of values between -∞ and +∞ and normalizes them so that each is between 0 and 1 and they all sum to 1.0
9. **cross-entropy loss/log loss**: a loss function that assigns predictions between 0 and 1 a loss between 0 (for perfect predictions) and ∞ (for exactly wrong predictions)
10. **sigmoid function**: a function that takes any real number and squashes it into a range between 0 and 1 and whose derivative f'(x) = f(x)(1 - f(x))
11. **sigmoid formula**: f(x) = 1 / (1 + e^-x)

## Recurrent Neural Networks

1.  **Recurrent Neural Network (RNN)**: A type of neural network where connections between nodes can create a cycle, allowing output from some nodes to affect subsequent input to the same nodes.
2.  **Long Short-Term Memory (LSTM)**: An RNN architecture that includes a cell state, hidden state, and forget, input, and output gates to manage memory
3.  **Memory Cell**: A component of an RNN that maintains information over time, allowing for long-term dependencies
4.  **Gated Recurrent Unit (GRU)**: A type of RNN that uses just uses the hidden state, with update and reset gates controlling memory
5.  **Hadamard product**: The element-wise product of two matrices or vectors without any transposition
6.  **Encoder-Decoder Architecture**: NN architecture used for sequence-to-sequence tasks that converts variable input into a fixed-length context vector and then decodes it into an output sequence step by step
7.  **Attention Mechanism**: Attention Mechanism: A process in neural networks that dynamically focuses on specific parts of the input data, improving tasks like translation or summarization by weighting relevant information
8.  **Bidirectional RNN**: An RNN architecture that processes sequences in both forward and backward directions, capturing past and future context simultaneously
9.  **Sequence-to-Sequence Model**: A type of neural network that transforms an input sequence into an output sequence, often used in tasks like translation or summarization
10. **Teacher Forcing**: Only using correct output from the previous time step rather than using a model's own output as input during training
11. **Forget Gate**: A component in LSTM networks that decides which information to discard from the cell state based on current input and hidden state
12. **Input Gate**: A component in LSTM networks that controls how much new information is allowed into the cell state based on the input and hidden state
13. **Output Gate**: A component in LSTM networks that determines how much of the cell state should be exposed as the hidden state at the current time step
14. **Update Gate**: A mechanism in GRUs that controls how much of the hidden state is updated with new information, balancing between past and current inputs
15. **Reset Gate**: A mechanism in GRUs that determines how much of the previous hidden state should be forgotten when processing new input


## Transformers

1.  **Transformer**: A neural network architecture designed to handle sequential data, using self-attention mechanisms to capture dependencies without relying on recurrence
2.  **Self-Attention**: A mechanism in transformers that allows each position in the sequence to focus on all other positions to compute a new representation
3.  **Multi-Head Attention**: A mechanism that applies attention multiple times in parallel, allowing the model to focus on different parts of the input sequence simultaneously and learn richer representations
4.  **Positional Encoding**: Injecting information about the order of elements in a sequence into the input embeddings of a transformer model
5.  **Autoregressive Model**: A model that generates the next element in a sequence by conditioning on the previous elements
6.  **Embedding Matrix**: *A matrix that maps discrete tokens to continuous vectors, allowing the model to learn representations of the input tokens.*
7.  **Language Modeling Head**: The final layer of a language model responsible for predicting the next token or word based on the model’s learned representations
8.  **Unembedding Matrix**: A matrix that maps the model’s hidden representations back into the vocabulary space for token prediction
9.  **Attention**: The mechanism that weighs and combines the representations from approprate other tokens in the context allowing the model to focus on the most relevant parts of the sequence
10. **Query**: A vector used in attention mechanisms to determine how much focus should be placed on other input elements, compared against keys
11. **Key**: A vector in attention mechanisms that is compared against queries to compute attention scores for input elements
12. **Value**: A vector that carries information associated with each key, used to compute the final weighted output in attention mechanisms
13. **Attention Head**: A single application of the attention mechanism in multi-head attention, processing a subset of the input’s dimensions
14. **LayerNorm**: A normalization technique that stabilizes training by normalizing the activations across a layer, helping to maintain scale and distribution
15. **Masked Language Model**: A model trained to predict missing or masked tokens in a sequence, often used in pretraining for sequence generation tasks
16. **Cloze Task**: A task where a model predicts missing words or tokens in a sentence, used to evaluate language models’ understanding of context
17. **Anisotropy**: When the embeddings of a model are distributed unevenly in the space and tend to have cosine similarity close to 1

## Large Language Models

1. **in-context learning**: A model’s ability to learn patterns or tasks directly from the input sequence without additional fine-tuning, based purely on the input provided
2. **zero-shot learning**: The ability of a model to perform tasks it hasn’t been explicitly trained on by generalizing from related knowledge
3. **few-shot learning**: The ability of a model to learn a new task with only a few examples provided during inference
4. **induction head**: An attention head in large models that tracks repeating patterns in sequences, enabling in-context learning and pattern induction
6. **ablation**: an NLP technique used for understanding causal effect where parts of the model are removed to understand their contribution to the model's performance