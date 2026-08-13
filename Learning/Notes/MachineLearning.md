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





# 3. Unsupervised Learning

## 3.1 What I understood

In Unsupervised Learning we give the algorithm the inputs X, but don't give the labels Y.

3 types of Unsupervised Learning:
**Clustering** - The algorithm tries to find some structure/some pattern in the dataset so it can group them together into groups/clusters. Example: DNA micro array
**Anomaly detection** - Example: Fraud detection
**Dimensionality reduction** - Example: Shrink data without losing too much information

## 3.2 Questions

- What is Anomaly detection?
- What is Dimensionality reduction?
- How the algorithm groups data into groups/cluster? How it decides whether or not it belongs to group 1 or group 2?





# 4. Linear regression model

## 4.1 What I understood

Linear regression model is a regression model which is Supervised Learning model. We give the model our data called "Training set", the model learns on this "Training set"
and then predicts a number on a new input.

The inputs is denoted as 'x' (called input, input feature) and the output target is denoted as 'y' (called output target).
The model's estimate/prediction is denoted as ŷ (y-hat) called estimate/prediction. The 'm' denotes the number of training examples.
The (x, y) denotes single training example.

So the model takes Training set and pass it to learning algorithm called a function 'f'. Linear regression model uses a straight line or a linear function to fit 
the data. The function 'f' (called model) takes the input x (called feature) and returns an estimate/prediction denoted as 'ŷ' (y-hat).
Function for Linear regression is: f(x) = wx + b, where x is input feature and w,b are other variables.
This is example of Univariate Linear Regression or Linear Regression with one variable (one input feature).

## 4.2 Questions

- How the model actually trains on the training set?
- What are "variables" w and b?
- What is the function for Linear Regression with multiple variables (more input features)?





# 5. Cost function

## 5.1 What I understood

Recall the model is $f(x) = wx + b$, where $w,b$ are parameters (called weights, coefficients).
These parameters are variables that the model can adjust during training to get better results.
The parameter '$w$' affects the slope of a line and the parameter '$b$' offsets the line on the vertical axis Y.

The cost function will tell us how well the model is doing on the training set
so we can try to do it better overtime.

The cost function is used to measure how bad/good model's predictions are.
For cost function we need to measure an error, meaning measure what's the difference between model's prediction $ŷ$ and the output target $y$. 
The error is measured simply by $(ŷ^{(i)} - y^{(i)})^2$ = $(f_{w,b}(x^{(i)}) - y^{(i)})^2$. By using to the power of 2, the model gets more punishment for errors.
We need to sum up all the errors for each individual training example. Due to this, the error will get bigger with the size of the training set. To avoid that, we need to divide it by $\frac{1}{m}$. Using '2m' in $\frac{1}{2m}$ is just for easier work with the function and it does not change its behaviour.
The cost function is denoted as $J(w,b)$

So the Squared error cost function is: $J(w,b) = \frac{1}{2m} \sum_{i=1}^{m} \left( f_{w,b}(x^{(i)}) - y^{(i)} \right)^2$

Recall the model is: $$f_{w,b}(x) = wx + b$$
Parameters: $$w,b$$ 
Cost function: $$J(w,b) = \frac{1}{2m} \sum_{i=1}^{m} \left( f_{w,b}(x^{(i)}) - y^{(i)} \right)^2$$
Goal: $$minimize_{w,b}J(w,b)$$

The intuition behind the cost function is to tell us how well the model is doing on the training set.

The parameters $w$ and $b$ determine the model's predictions. Changing w and b changes the predictions, which changes the cost $J(w,b)$.

Our goal is to find values of $w$ and $b$ that minimize $J(w,b)$:

$$
\min_{w,b} J(w,b)
$$

The minimum of the cost function represents the best values of the parameters according to the chosen cost function.

For linear regression with squared error, the cost function has a
convex shape. With one parameter varying, it can be visualized as a
parabola. With both $w$ and $b$ varying, it can be visualized as a 3D
surface.

## 5.2 Questions

- How the model adjust the parameters $'w'$ and $'b'$?
- How the model works with the cost function to adjust its parameters?
- Exists other types of Cost function?
- Why is squared error cost function a good choice for many Regression problems?