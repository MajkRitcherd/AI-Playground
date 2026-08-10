# 1. What is Machine Learning?

## 1.1 What I understood

Machine Learning is the ability of PC/Algorighm solve a problem without being programmed for this case. The more data I give the Machine Learning -> It gives better outcome:

- Big dataset -> Better model than the model trained on small dataset
- Small dataset -> Worse than the model trained on big dataset

2 Machine Learning categories:
- Supervised Learning
- Unsupervised Learning

## 1.2 Questions

- How does PC learn?
- Why more examples gives better outcome?
- What is Supervised and Unsupervised Learning and its usage/application in real life

# 2. Supervised Learning

## 2.1 What I understood

Supervised Learning refers to an algorithm that maps the input X to labels Y. Then for a new input X, it predicts its output. The algorithm learns from having the "right answers".

Given the inputs X and its outputs Y (labels), the algorithm tries to find a function that fits the dataset the best,  it could be a straight line, a curve or any complicated function.

Examples of Supervised Learning algorithms: Email spam filter, Machine translation, Speech recognition, Housing price prediction, Online advertising, Self-driving car, Visual inspection

2 Types of Supervised Learning algorithms: **Regression** and **Classification**

**Regression** - The algorithm predicts a number (infinitely possible outputs). Example of such algorithm: Housing price prediction (e.g. Based on a size of a house, it predicts its price).

**Classification** - The algorithm predicts a class or category. It could be represented as a number, but it can have only small finite number of possible outputs. Examples of such algorithms: Cancer detection (e.g. Based on size of a tumor, it can predict whether or not the tumor is malignant or benign), Number detection from an image, Cat/Dog detection from an image.

The model can have multiple inputs, not just one input. For example: Tumor size + Age -> predicts if it is malignant or benign. The algorithm then tries to find a boundary line, where it believes in one part are malignant tumors and in the other part are benign tumors.

## 2.2 Questions

- How the model learns from inputs and its corresponding labels (outputs)?
- What are "right answers"?
- How does the algorithm finds the best fitting function/boundary line?
- When having multiple inputs, is it easier or harder to train the model?