# C++ Notes

## Table of Contents

<!-- Syntax

Vocabulary

Reserved Words

Variable declaration, initialization, and assignment

Operators
Arithmetic

Relational

Bitwise

Logical

Assignment

Other

Functions / Procedures

Data Structures

Decision making

Loops

Object Orientation
Classes

Access Specifiers

Methods

Constructors

Operator Overloading

Pointers

Error Handling

Other Aspects
Comments

Casting

Boolean Values

Null value(s)

Naming Conventions

Reserved Words

File importing
File reading/writing

Typing
Scope
Whitespace
Object orientation -->

## Vocabulary

- **Compiler**: A tool that translates C++ source code into machine code.
- **Linker**: Combines object files into a single executable.
- **Namespace**: Used to organize code and prevent name conflicts.
- **Standard Template Library (STL)**: A library of generic classes and functions.
- **Header File**: Files ending in `.h` or `.hpp` that declare functions, classes, or constants.
- **Pointer**: A variable that stores the memory address of another variable.
- **Reference**: An alias for another variable.
- **RAII (Resource Acquisition Is Initialization)**: A programming concept to manage resources.

## Concepts

- C++ is a compiled, statically-typed language.
- It supports both procedural and object-oriented programming.
- Offers low-level memory manipulation via pointers and references.
- Backward compatibility with C, but also supports modern programming paradigms.

## Notes

- Block scoped.
- Functions must be declared before use unless a prototype is provided.
- Primitive types like `int`, `double`, and `char` are built-in.

| Type     | Frequency of Use |
| -------- | ---------------- |
| Pointers | Commonly         |
| Structs  | Frequently       |
| Enums    | Commonly         |
| Arrays   | Occasionally     |
| Vectors  | Very Frequently  |

- The entry point of a C++ program is the `main` function.

### Libraries

- `<iostream>`: For input/output operations (`std::cin`, `std::cout`).
- `<vector>`: For dynamic arrays.
- `<string>`: For text manipulation.
- `<algorithm>`: For standard algorithms like `sort`.
- `<map>` / `<unordered_map>`: For associative containers.

## Syntax

- Single-line comments: `//`
- Multi-line comments: `/* */`
- Single quotes for characters: `'a'`
- Double quotes for strings: `"Hello"`

Casting:
- C-style: `(type)variable`
- `static_cast<type>(variable)`
- `reinterpret_cast<type>(variable)`
- `dynamic_cast<type>(variable)`
- `const_cast<type>(variable)`

Reserved words:

```cpp
alignas alignof asm auto bool break case catch char class const constexpr continue decltype default delete do double dynamic_cast else enum explicit extern false float for friend goto if inline int long mutable namespace new noexcept nullptr operator private protected public register reinterpret_cast return short signed sizeof static struct switch template this throw true try typedef typeid typename union unsigned using virtual void volatile wchar_t while
```

## Data Types

Primitive data types in C++ are:

- `int` - Integer
- `float` - Floating-point number
- `double` - Double-precision floating-point number
- `char` - Single character
- `bool` - Boolean value
- `void` - No type

Pointers:
- Use `*` for definition: `int* ptr`
- Use `&` to get an address: `int* ptr = &var`
- Dereference with `*`: `int value = *ptr`

References:
- Defined with `&`: `int& ref = var`

## Modifiers

- `const` - Read-only variable.
- `static` - Variable shared across instances.
- `mutable` - Allows modification of const member variables.
- `volatile` - Prevents optimization on variables that may change unexpectedly.

## Control Flow

- `if`, `else if`, `else`
- `while`, `do while`, `for` loops
- Ternary operator: `condition ? true_value : false_value`
- `switch` with `case` and `break`.

```cpp
switch (value) {
    case 1:
        // Do something
        break;
    default:
        // Default case
}
```

## Data Structures

The most common data structures in C++ are:

- Arrays (fixed size)
- Vectors (`std::vector` for dynamic size)
- Maps (`std::map`, `std::unordered_map`)
- Sets (`std::set`, `std::unordered_set`)

### Vectors

```cpp
#include <vector>

std::vector<int> numbers = {1, 2, 3};
numbers.push_back(4);
int first = numbers[0];
numbers.pop_back();
```

### Strings

```cpp
#include <string>

std::string name = "Alice";
std::cout << "Hello, " << name << "!" << std::endl;
```

### Enums

```cpp
enum Color { RED, GREEN, BLUE };
Color favorite = GREEN;
```

## Functions

Function definition:

```cpp
int Add(int a, int b) {
    return a + b;
}
```

Default parameters:

```cpp
int Add(int a, int b = 0) {
    return a + b;
}
```

Function overloading:

```cpp
int Multiply(int a, int b) { return a * b; }
double Multiply(double a, double b) { return a * b; }
```

## Object Orientation

Classes:

```cpp
class MyClass {
public:
    int value;
    MyClass(int v) : value(v) {}
    void Display() const {
        std::cout << value << std::endl;
    }
};
```

## Common Tasks

Input/Output:

```cpp
#include <iostream>
std::cout << "Hello, World!" << std::endl;
std::cin >> variable;
```

File operations:

```cpp
#include <fstream>
std::ofstream file("example.txt");
file << "Hello, File!" << std::endl;
file.close();
```

Memory management:

```cpp
int* ptr = new int(5);
delete ptr;
```

## Naming Conventions

- PascalCase for classes.
- camelCase for variables and functions.
- UPPERCASE for constants.

## Thoughts

### Positives

- High performance.
- Control over memory and hardware.
- Rich standard library (STL).

### Negatives

- Manual memory management.
- Complex syntax for beginners.
- Error-prone (undefined behavior, dangling pointers).

## Questions

- [x] What's the role of header files?
- [x] What are the differences between `std::vector` and arrays?
- [ ] How do templates work?
- [ ] What's the best way to handle exceptions?
- [ ] When to use pointers vs references?
