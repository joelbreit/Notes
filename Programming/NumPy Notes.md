# NumPy Notes

## NumPy Basics

1. **NumPy**: a Python library for numerical computing that provides support for large, multi-dimensional arrays and matrices
2. **array**: a grid of values, all of the same type, indexed by a tuple of non-negative integers
3. **dimension**: the number of axes in an array
4. **shape**: the size of each dimension of an array
5. **dtype**: an object describing the data type of the array
6. **itemsize**: the size in bytes of each element of the array
7. **ndarray**: the NumPy array object
8. **axis**: a specific dimension of an array
9. **rank**: the number of dimensions of an array
10. **scalar**: a single number
11. **vector**: a 1D array
12. **matrix**: a 2D array
13. **tensor**: an array with more than two axes
14. **broadcasting**: a set of rules for applying binary ufuncs (e.g., addition, subtraction, multiplication, etc.) on arrays of different sizes
15. **universal functions (ufuncs)**: functions that operate element-wise on arrays
16. **element-wise operations**: operations that are applied to corresponding elements of two arrays
17. **dot product**: a mathematical operation that takes two equal-length sequences of numbers and returns a single number
18. **reshape**: a method that changes the shape of an array without changing the data
19. **transpose**: a method that flips the shape of an array
20. **ufuncs**: functions that operate element-wise on arrays
21. **method chaining**: a programming paradigm where multiple methods are called on an object in sequence

## Boilerplate

```python
import numpy as np
```

## NumPy Array Creation

**np.array() Function** - Create an array from a list

```python
data = [1, 2, 3, 4, 5]
arr = np.array(data)
# [1 2 3 4 5]
```

**np.zeros() Function** - Create an array of zeros

```python
arr = np.zeros(10)
# [0. 0. 0. 0. 0. 0. 0. 0. 0. 0.]
```

