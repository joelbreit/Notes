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

### **Most Used / Most Important**
1. `int` – Fundamental data type
2. `return` – Essential for function results
3. `if` – Core control structure
4. `else` – Used with `if`
5. `for` – Most common loop type
6. `while` – Another key loop
7. `void` – Function return type
8. `bool` – Fundamental type for logic
9. `true` / `false` – Boolean literals
10. `const` – Used extensively for immutability
11. `static` – Important for memory and linkage
12. `namespace` – Essential in modern C++
13. `using` – Critical for managing scope
14. `class` – Core to OOP in C++
15. `struct` – Similar to `class` but used for plain data structures
16. `public` / `private` / `protected` – Access control in classes
17. `auto` – Type inference, widely used in modern C++
18. `new` / `delete` – Manual memory management (less used with smart pointers)
19. `nullptr` – Replaces `NULL` in modern C++
20. `this` – Refers to current instance in class methods
21. `operator` – Overloading operators
22. `enum` – Defining named constants

### **Moderately Used**
23. `switch` / `case` / `default` – Alternative to `if-else`
24. `break` – Often used in loops and `switch`
25. `continue` – Controls loop execution
26. `do` – Used with `while`
27. `sizeof` – Gets type size, common in low-level code
28. `dynamic_cast` / `static_cast` / `reinterpret_cast` / `const_cast` – Used in casting
29. `template` – Foundation of generic programming
30. `typename` – Used in templates
31. `friend` – Grants special access to private members
32. `explicit` – Prevents implicit conversions
33. `virtual` – Essential for polymorphism
34. `override` – Enforces correct overriding in inheritance
35. `final` – Prevents further inheritance
36. `try` / `catch` / `throw` – Exception handling
37. `volatile` – Important in embedded systems
38. `register` – Mostly ignored by modern compilers
39. `mutable` – Allows modification of `const` members

### **Rarely Used**
40. `goto` – Generally avoided
41. `alignas` / `alignof` – Memory alignment
42. `thread_local` – Thread storage specifier
43. `decltype` – Used for type deduction
44. `noexcept` – Marks functions that don’t throw exceptions
45. `constexpr` – Compile-time constants
46. `static_assert` – Compile-time assertions
47. `export` – Almost never used
48. `co_await` / `co_yield` / `co_return` – Coroutine keywords (C++20)


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
- [ ] `WaitForSingleObject` vs `WaitForMultipleObjects`?
- [ ] `ReleaseMutex`
- [ ] Enum syntax
  - [ ] ::