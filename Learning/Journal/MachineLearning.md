# 2026-08-09

## I was learing

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - What is machine learning?

## I understood

- Machine Learning solves problem without being explicitly programmed to solve the problem
- More data -> Better outcomes
- 2 categories: Supervised and Unsupervised Learning

## What I did not understand?

- How the Machine Learning learns?
- Why more data results in better outcome?
- What is the difference between Supervised and Unsupervised Learning?





# 2026-08-10

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Supervised Learning part 1 and part 2
Week 1 - Unsupervised Learning part 1 and part 2

## I understood

- Supervised learning maps the input X to outputs Y, the model predicts output for a new input X (even for a brand new input X)
- 2 types of algorithms: Regression (Predicts a number) and Classification (Predicts a class/category)
- Unsupervised learning tries to find some structure/pattern in the data.
- 3 types of algorithms: Clustering (grouping similar data into groups/clusters), Anomaly detection (used in Fraud detection) and Dimensionality reduction (Shrink data without losing too much information)

## What I did not understand?

- How the model learns to map inputs X to outputs Y?
- How the model finds the best fitting function for a dataset?
- Is it easier/harder for model to learn when having multiple inputs?
- What is Anomaly detection and Dimensionality reduction
- How the algorithm whether or not the input X belongs to that or that group?





# 2026-08-11

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Linear regression model part 1 and part 2

## I understood

- The idea behind the Linear Regression model
- Basic notation: x = input features, y = output targets, y-hat = estimates/predictions, m = number of training examples, (x, y) = Single training example
- Function f(x) = wx + b, although don't know what w,b is

## What I did not understand?

- How the model trains or how it improves its performance
- What are "variables" w and b
- What is the function for Linear regression with multiple variables





# 2026-08-12

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Cost function formula

## I understood

- Cost function measures how well the model's predictions fit the training set.
- For linear regression, we can use squared error cost.
- Larger errors contribute disproportionately more to the cost.
- J(w,b) depends on the model parameters w and b.
- 1/m prevents the cost from growing simply because the training set is larger.
- 1/2 is mainly a mathematical convenience for later derivatives.

## What I did not understand?

- How does the model choose better values of w and b?
- How can we know which direction w and b should move?
- How does Gradient Descent use J(w,b)?





# 2026-08-13

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Cost function intuition

## I understood

- Intuition behind the Cost Function
- For model with one variable, the Cost Function can be visualized as parabola

## What I did not understand?

- How does the model choose better values of w and b?
- How can we know which direction w and b should move?
- How does Gradient Descent use J(w,b)?





# 2026-08-14

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Visualizing the cost function

## I understood

- 2 different visualizations:
  - When Cost Function $J$ has only 1 parameter, such as $w$, visualization of Cost Function $J(w)$ looks like a Parabola
  - When Cost Function $J$ has 2 parameters, such as $w,b$, visualization of Cost Function $J(w,b)$ looks like a bowl
- We can use Contour plots for visualization


## What I did not understand?

- How does it look for more comples Cost Functions $J$ (more than 2 parameters)?





# 2026-08-17

## I was learning

Andrew Ng - Machine Learning Specialization
Supervised Machine Learning: Regression and Classification
Week 1 - Visualization examples

## I understood

- How changing $w,b$ changes the Cost Function $J$ and its visualization using contour plot and 3D plot.