# Python Notes

...

## Functions

### ...

### Parameters

#### ...

#### Variable Positional Arguments

`*args` - parameter used for collecting any number of extra positional arguments as a tuple
- `*args` is a convention, but you can use any name preceded by an asterisk (`*`).

```python
def my_function(*args):
    for arg in args:
        print(arg)
```

#### Variable Keyword Arguments

`**kwargs` - parameter used for collecting any number of extra keyword arguments as a dictionary
- `**kwargs` is a convention, but you can use any name preceded by two asterisks (`**`).

```python
def my_function(**kwargs):
    for key, value in kwargs.items():
        print(f"{key}: {value}")
```

#### Parameter Order

Python has this **specific order** for function parameters:
```python
def func(pos1, pos2, *args, kw1=None, **kwargs):
    ...
```
| Type                | Example        | Description                                      |
| ------------------- | -------------- | ------------------------------------------------ |
| Positional          | `pos1`, `pos2` | Required positional arguments                    |
| Variable Positional | `*args`        | Collects extra positional arguments as a tuple   |
| Keyword             | `kw1=None`     | Optional keyword argument with a default value   |
| Variable Keyword    | `**kwargs`     | Collects extra keyword arguments as a dictionary |

## ...

### Unpacking

- **Unpacking** is a way to extract values from a collection (like a list or tuple) and assign them to variables.
- `*` unpacks a list or tuple
- `**` unpacks a dictionary

```python
def my_function(a, b, c):
    print(a, b, c)

my_list = [1, 2, 3]
my_function(*my_list)  # Output: 1 2 3

my_dict = {'a': 1, 'b': 2, 'c': 3}
my_function(**my_dict)  # Output: 1 2 3
```

...

### Decorators

- Decorators are a way to modify or enhance functions or methods in Python.
- They are often used for logging, access control, memoization, and more.
- A decorator is a function that takes another function as an argument and returns a new function that adds some kind of functionality.
- Decorators are often used with the `@decorator_name` syntax above the function definition.
- They can be stacked, meaning you can apply multiple decorators to a single function.
- Decorators can also take arguments, allowing for more flexible and reusable code.
- They can be used to modify the behavior of functions, methods, or classes.

```python
# Decorator function
def my_decorator(func):
    def wrapper(*args, **kwargs):
        print("Something is happening before the function is called.")
        result = func(*args, **kwargs)
        print("Something is happening after the function is called.")
        return result
    return wrapper

# Applying the decorator
@my_decorator
def say_hello(name):
    print(f"Hello, {name}!")

# Output:
# Something is happening before the function is called.
# Hello, John!
# Something is happening after the function is called.
```

### Built-In Variables

**`__name__`** - Module name identifier. If the module is being run directly, `__name__` is set to `"__main__"`, otherwise it is set to the module's name.

**`__file__`** - The path to the file being executed. This can be used to determine the location of the script or module.
