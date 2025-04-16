# C++ Notes

## Table of Contents

- [C++ Notes](#c-notes)
  - [Table of Contents](#table-of-contents)
  - [Vocabulary](#vocabulary)
  - [Concepts](#concepts)
  - [Notes](#notes)
    - [Libraries](#libraries)
  - [Syntax](#syntax)
  - [Data Types](#data-types)
  - [Modifiers](#modifiers)
  - [Control Flow](#control-flow)
  - [Data Structures](#data-structures)
  - [Functions](#functions)
  - [Object Orientation](#object-orientation)
  - [Common Tasks](#common-tasks)
  - [Naming Conventions](#naming-conventions)
  - [More](#more)
    - [Preprocessor Directives](#preprocessor-directives)
  - [Thoughts](#thoughts)
    - [Positives](#positives)
    - [Negatives](#negatives)

## Vocabulary

- **Compilation**: Direct conversion of C++ source code to machine code
- **Linker**: Program that combines object files and libraries into an executable
- **Header Files**: Files (usually .h) containing declarations of functions and classes
- **Source Files**: Files (usually .cpp) containing the implementation
- **Template**: A way to write generic code that works with different data types
- **STL (Standard Template Library)**: Collection of template classes and functions
- **Vector**: The most commonly used dynamic array container in C++
- **Reference**: An alias for an existing variable
- **Smart Pointer**: Objects that manage memory allocation automatically

## Concepts

- C++ is compiled directly to machine code, making it very fast
- Memory management is manual by default but can be automated with smart pointers
- Supports both procedural and object-oriented programming
- Strong type system with compile-time type checking
- Extensive standard library (STL) providing common data structures and algorithms

## Notes

- Block scoped
- Supports both stack and heap memory allocation
- Manual memory management with `new` and `delete`
- Modern C++ emphasizes RAII (Resource Acquisition Is Initialization)
- Entry point is the `main()` function, which returns an integer

### Libraries

Standard libraries are included with angle brackets:
```cpp
#include <iostream>  // Input/output streams
#include <vector>    // Dynamic arrays
#include <string>    // String handling
#include <algorithm> // Algorithms like sort, find
#include <memory>    // Smart pointers
```

User-defined headers use quotes:
```cpp
#include "myheader.h"
```

## Syntax

- 'Single quotes' for characters
- "Double quotes" for strings
- Format strings using `cout` and `<<` operator or `printf`
- Casting:
  - C-style: `(type)variable`
  - Static cast: `static_cast<type>(variable)`
  - Dynamic cast: `dynamic_cast<type>(variable)`
  - Const cast: `const_cast<type>(variable)`
  - Reinterpret cast: `reinterpret_cast<type>(variable)`

## Data Types

Primitive data types:

- `int` - integer (usually 32-bit)
  - Also `short`, `long`, `long long` for different sizes
  - Unsigned versions with `unsigned` prefix
- `double` - 64-bit floating-point
  - Also `float` for 32-bit floating-point
- `char` - single character
- `bool` - true or false
- `void` - no type

Pointers and References:
```cpp
int* ptr = &num;        // Pointer
int& ref = num;         // Reference
const int* ptr;         // Pointer to constant
int* const ptr;         // Constant pointer
const int* const ptr;   // Constant pointer to constant
```

## Modifiers

- `const` - constant value
- `static` - class-wide variable/function
- `volatile` - value may change externally
- `mutable` - can change in const member function
- `virtual` - can be overridden by derived class

## Control Flow

Similar to C:
```cpp
// If statement
if (condition) {
    // code
} else if (otherCondition) {
    // code
} else {
    // code
}

// Switch statement
switch (value) {
    case 1:
        // code
        break;
    default:
        // code
}

// Loops
for (int i = 0; i < n; i++) { }
while (condition) { }
do { } while (condition);

// Range-based for (C++11)
for (const auto& item : container) { }
```

## Data Structures

STL Containers:
- `vector<T>` - Dynamic array
- `array<T,N>` - Fixed-size array
- `list<T>` - Doubly-linked list
- `forward_list<T>` - Singly-linked list
- `deque<T>` - Double-ended queue
- `set<T>` - Ordered unique elements
- `map<K,V>` - Key-value pairs
- `unordered_set<T>` - Hash set
- `unordered_map<K,V>` - Hash map

Example vector usage:
```cpp
vector<int> numbers = {1, 2, 3, 4, 5};
numbers.push_back(6);
numbers.pop_back();
auto first = numbers.front();
auto last = numbers.back();
```

## Functions

Function overloading:
```cpp
int add(int a, int b) { return a + b; }
double add(double a, double b) { return a + b; }
```

Default parameters:
```cpp
void print(string msg = "Hello") {
    cout << msg << endl;
}
```

Templates:
```cpp
template<typename T>
T max(T a, T b) {
    return (a > b) ? a : b;
}
```

Lambda functions (C++11):
```cpp
auto sum = [](int a, int b) { return a + b; };
```

## Object Orientation

Classes:
```cpp
class Animal {
private:
    string name;
    
public:
    // Constructor
    Animal(string n) : name(n) {}
    
    // Virtual destructor
    virtual ~Animal() {}
    
    // Member function
    virtual void makeSound() {
        cout << "Some sound" << endl;
    }
};
```

Inheritance:
```cpp
class Dog : public Animal {
public:
    Dog(string n) : Animal(n) {}
    
    void makeSound() override {
        cout << "Woof!" << endl;
    }
};
```

## Common Tasks

Basic I/O:
```cpp
#include <iostream>
using namespace std;

int main() {
    string name;
    cout << "Enter name: ";
    cin >> name;
    cout << "Hello, " << name << endl;
    return 0;
}
```

String operations:
```cpp
string str1 = "Hello";
string str2 = " World";
string result = str1 + str2;  // Concatenation
```

## Naming Conventions

- Classes: PascalCase
- Functions/Methods: camelCase
- Variables: camelCase
- Constants: UPPER_CASE
- Private members: m_prefixed or _prefixed

## More

### Preprocessor Directives

Preprocessor directives start with `#` and are processed before compilation effectively transorming the source code before it is compiled.

- `#include` - Include header file
- `#define` - Define a macro
- `#ifdef`, `#ifndef`, `#else`, `#endif` - Conditional compilation

## Thoughts

### Positives
- Very fast execution
- Direct hardware access
- Extensive standard library
- Flexible programming paradigms
- Strong type system

### Negatives
- Manual memory management
- Complex syntax
- Long compilation times
- No garbage collection
- Steep learning curve