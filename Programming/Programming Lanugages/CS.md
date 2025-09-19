# Computer Science Flashcards

Flashcards should work both ways
- Term -> Definition as well as Definition -> Term
- The definition should never use the entire term and should try to avoid using part of the term
- The definition should be concise
  - Use "using domain knowledge..." over "using domain knowledge and expertise..."
  - Use "ML technique that..." over "a type of machine learning where the system..."
  - Use "allowing..." instead of "the practice of allowing..."
- The definition should not be too abstract
  - Instead of "a structured representation of the meaning of a word or phrase" use "a set of words that denote aspects of a particular type of event like a commercial transaction"
- Don't list synonyms unnecessarily

## Computer Science Concepts

### Performance Complexity

1.  **big O notation** - *metric for performance of an algorithm that describes the worst-case scenario and simplifies by removing constants and lower order terms*
2.  **logarithmic time** - *performance complexity that increases by diminishing amounts as the input size grows*
3.  **linear time** - *performance complexity that increases consistently with the input size*

## Coding Concepts

1. **camel case** - *namingConventionWhereEachWordStartsWithACapitalLetter*
2. **kebab case** - *naming-convention-where-words-are-separated-by-hyphens*
3. **snake case** - *naming_convention_where_words_are_separated_by_underscores*
4. **sentence case** - *NamingConventionWhereTheFirstWordIsCapitalized*
   
5.  **escape character/escape sequence** - *a character or sequence of characters that represents a special character in a string*

### Scope

1. **block scope** - *the area of code where a variable is accessible*
2. **function scope** - *the area of code where a variable is accessible within a function*
3. **global scope** - *the area of code where a variable is accessible throughout the program*
4. **local scope** - *the area of code where a variable is accessible within a block or function*
5. **lexical scope** - *the area of code where a variable is accessible based on its position in the source code*
6. **module scope** - *the area of code where a variable is accessible within a module*
7. **namespace** - *a container for a set of identifiers that are used to organize code and prevent naming conflicts*
8. **variable shadowing** - *the process of declaring a variable with the same name as a variable in an outer scope, which hides the outer variable*
9. **hoisting** - *the process of moving variable and function declarations to the top of their containing scope during compilation*
10. **closure** - *a function that captures the variables from its lexical scope, allowing it to access those variables even after the scope has exited*
11. **context** - *the value of `this` within a function, which is determined by how the function is called*
12. **this** - *a keyword that refers to the object that a method is called on*
13. **self** - *a reference to the current object within a method*
14. **super** - *a keyword that refers to the superclass of a class*
15. **prototype** - *an object that is used as a template for creating other objects*
16. **contextual this** - *the value of `this` within a function, which is determined by how the function is called*
17. **lexical this** - *the value of `this` within a function, which is determined by the function's lexical scope*
18. **dynamic scope** - *the area of code where a variable is accessible based on the call stack*
19. **static scope** - *the area of code where a variable is accessible based on the lexical structure of the code*


## Programming Concepts

### Memory Management Models

1. **stack** - region of memory that grows and shrinks automatically as functions are called and return
2. **heap** - flexible region of memory for objects that outlive their immediate scope, *requiring explicit freeing (manual memory) or runtime tracking (GC, ARC, etc.)*
3. **reference counting** - a garbage collection technique that counts the number of references to an object and deallocates it when the count reaches zero
4. **unique pointer** - a smart pointer that owns the object it points to and deallocates the object when it goes out of scope
5. **shared pointer** - a smart pointer that uses reference counting and deallocates the object when the count reaches zero
6. **weak reference** - a reference that does not prevent its subject from being deallocated
7.  **ownership memory model** - a memory management model where objects have a single owner that is responsible for deallocating them (Rust)
8.  **reference cycle** - a situation where two or more objects reference each other, preventing them from being deallocated
9.  **manual memory management** - a memory management model where the programmer is responsible for allocating and deallocating memory (C)
10. **garbage collection (GC)** - memory management via a background process that automatically finds and frees unused (unreachable) memory (Java, Python)
11. **automatic reference counting (ARC)** - a garbage collection technique primarily relies on reference counting to free up memory (Swift)
12. **resource acquisition is initialization (RAII)** - a programming idiom where cleanup of resources is tied to the lifespan of an object

### Programming Paradigms

1. **(programming) paradigm** - a fundamental style or approach to writing and organizing code, defining how problems are structured and solved
2. **imperative programming** - programming paradigm focused on step-by-step instructions and explicit state changes
3. **procedural programming** - subset of imperative programming using reusable blocks
4. **object-oriented programming** - programming paradigm based on classes and instances that contain data and methods
5. **declarative programming** - programming paradigm focused on describing the desired result without specifying the step-by-step instructions
6. **functional programming** - subset of declarative programming focused on functions as first-class citizens and immutable data

### Execution Styles

1. **compiled language** - a language that is translated to a lower-level representation (usually machine code) before execution (C/C++, Rust, Go)
2. **interpreted language** - a language that can be run without being fully compiled  (Python, Ruby, JavaScript)
3. **just-in-time (JIT) compiler** - a program that compiles bytecode into machine code at runtime rather than ahead of time
4. **virtual machine (VM)** - a program that runs or further compiles bytecode
5. **transpiling** - when source code is converted from one high-level language to another (TypeScript and React transpile to JavaScript)
6. **bytecode** - platform-independent intermediate representation of a program that can be executed or further compiled by a virtual machine
7. **machine code** - CPU-specific binary instructions that can be executed directly by hardware

### Code Processing Steps

1. **code parsing** - broad term for iterating through code as part of a larger task
2. **code building** - the process of preparing code for execution
3. **code compilation** - translating code into a lower-level representation
4. **code linking** - combining compiled pieces of code into a single thing after compilation
5. **code packaging** - bundling code and dependencies for distribution at the end of the build process
6. **code running** - broad term for doing the tasks descibed by some set of code
7. **code interpretation** - running code without prior compilation
8. **code execution** - running code that has been compiled (usually to machine code)
9. **code rendering** - turning code/data into a displayable format

### Data Structures

1.  **array** - Data structure that stores elements of the same type in contiguous memory locations
2.  **dynamic array** - *a resizable array that grows or shrinks as needed*
3.  **associative array** - *a data structure that stores key-value pairs*
4.  **map** - *a data structure that stores key-value pairs*
5.  **set** - *a data structure that stores unique elements*
6.  **list** - *a data structure that stores a sequence of elements*
7.  **stack** - *a data structure that stores elements in a last-in, first-out order*
8.  **queue** - *a data structure that stores elements in a first-in, first-out order*
9.  **linked list** - *a data structure that stores elements in a sequence and maintains pointers to the next element*
10. **doubly linked list** - *a linked list that maintains pointers to both the next and previous elements*
11. **circular linked list** - *a linked list where the last element points to the first element*
12. **tree** - *a data structure that stores elements in a hierarchical structure*
13. **binary tree** - *a tree where each node has at most two children*
14. **binary search tree** - *a binary tree where the left child is less than the parent and the right child is greater than the parent*
15. **balanced tree** - *a tree where the height of the left and right subtrees of any node differ by at most one*
16. **heap** - *a binary tree where each node is greater than or equal to its children*
17. **priority queue** - *a data structure that stores elements in order of priority*
18. **graph** - *a data structure that stores elements and their relationships*
19. **adjacency list** - *a data structure that stores a list of neighbors for each vertex in a graph*
20. **adjacency matrix** - *a data structure that stores a matrix of connections between vertices in a graph*
21. **hash table** - *a data structure that stores key-value pairs and provides constant-time lookup*
22. **trie** - *a data structure that stores strings in a tree-like structure*
23. **bloom filter** - *a data structure that tests for membership of an element in a set*
24. **bit array** - *a data structure that stores bits in an array*
25. **struct** - *a composite data type that groups together variables of different types*

### Object-Oriented Programming

* **polymorphism** - allowing different types to be used in a single context like a function allowing for multiple types of arguments or allowing subclasses to be treated as their superclass
* **abstraction** - generalizing and removing details to focus on the most important characteristics
* **encapsulation** - preventing external code from being concerned with the internal workings of an object by bundling data and methods
* **inheritance** - *a mechanism for creating a new class that reuses the properties and methods of an existing class*
* **single inheritance** - *a class can inherit from only one superclass*
  * Java and C# use single inheritance for classes but allow multiple inheritance for interfaces
* **multiple inheritance** - *a class can inherit from multiple superclasses*
  * C++ and Python allow multiple inheritance for classes
* **diamond problem** - "if classes B and C inherit from A, and D inherits from both B and C, which version of A's methods does D get?"
* **decoupling** - *reducing dependencies between components*
* **alias** - *a reference to a memory location that holds a value*
* **static** - *a variable or method that belongs to the class and not to instances of the class*
* **public** - *a variable or method that can be accessed from outside the class*
* **private** - *a variable or method that can only be accessed from within the class*
* **interpolation** - *inserting a variable into a string*
* **class** - a blueprint for creating objects that defines their properties and methods
* **instance** - *a specific object created from a class*
* **property** - a variable that belongs to an object
* **method** - a function that belongs to an object and defines its behavior
* **object** - *an instance of a class*
* **subclass/child class** - *a class that inherits from another class*
* **superclass/parent class** - *a class that is inherited from*
* **constructor** - *a special method that is called when an object is created*
* **composition** - *a design technique that models a has-a relationship between objects*
* **aggregation** - *a design technique that models a has-a relationship between objects*
* **overloading** - *defining multiple methods with the same name but different parameters*
* **overriding** - *replacing a method in a subclass with a new implementation*
* **interface** - *a contract that defines the methods that a class must implement*
* **abstract class** - *a class that cannot be instantiated and is used as a base class for other classes*
* **sealed class** - *a class that cannot be inherited from*
* **singleton** - *a design pattern that restricts the instantiation of a class to one object*
* **factory method** - *a method that creates objects without specifying the exact class of object that will be created*
* **dependency injection** - *a design pattern that allows the removal of hard-coded dependencies and makes it possible to change them, either at run-time or compile-time*
* **modularity** - *the degree to which a system's components may be separated and recombined*
* **class instance** - *an object that is created from a class*

## Unorganized

* **run-time** - *period during which a program is being executed*
* **compile-time** - *period during which a program is being converted from human-readable code to machine code*

* **formal variable** - *a variable that is declared in a function or method*
* **local variable** - *a variable that is declared inside a block or function and is only accessible within that block or function*
* **global variable** - *a variable that is declared outside of any function or block and is accessible throughout the program*
* **class variable** - *a variable that is shared among all instances of a class*
* **instance variable** - *a variable that is unique to each instance of a class*
* **parameter** - *a variable that is used to pass information to a function or method*
* **type parameter** - *a parameter that specifies a type in a generic class or function*
* **argument** - *a value that is passed to a function or method*
* **statement** - *a complete instruction that performs an action*
* **expression** - *a piece of code that evaluates to a single value*


* **idempotence** - *property of an operation that can be applied multiple times without changing the result beyond the initial application*
* **identifier** - *a name that identifies a variable, function, or other entity*
* **assignment** - *the process of giving a variable a value*


* **function** - *a set of instructions organized together to perform a specific task*
* **procedure** - *a set of instructions organized together to perform a specific task*
* **method** - *a function that belongs to an object and defines its behavior*


* **type** - *a category of values that share common characteristics*
* **primitive** - *a basic data type that is not composed of other data types*
* **data structure** - *a way of organizing and storing data so that it can be accessed and modified efficiently*
* **package** - *a collection of related classes and interfaces*
* **import** - *a statement that allows classes and interfaces from a package to be used in a program*
* **print** - *a function that displays output to the console*
* **literal** - *a fixed value that is written directly in the code*
* **reference datatype** - *a data type that stores references to objects in memory*
* **value datatype** - *a data type that stores values directly*
* **variable** - *a named storage location that can hold a value*
* **identifier** - *a name that identifies a variable, function, or other entity*
* **assignment** - *the process of giving a variable a value*
* **idempotent** - *property of an operation that can be applied multiple times without changing the result beyond the initial application*
* **accessor method** - *a method that retrieves the value of a property*
* **field** - *a variable that is associated with a class or object*
* **property** - *a characteristic of an object, such as its color or size*
* **member** - *a variable or method that is associated with a class or object*


* **operator** - *a symbol that performs an operation on one or more operands*
* **operand** - *a value that is operated on by an operator*
* **mixin** - *a class that provides a set of methods that can be added to other classes*
* **trait** - *a set of methods that can be added to a class to provide additional functionality*
* **interface** - *a contract that defines the methods that a class must implement*
* **key** - *a unique identifier for a value in a data structure*
* **domain** - *the set of possible input values for a function*
* **library** - *a collection of precompiled routines that a program can use*
* **embedding** - *the process of including one object within another object*
* **embedded** - *a term used to describe an object that is included within another object*
* **symbols** - *the basic elements of a programming language*
* **terminals** - *the basic elements of a programming language*
* **parent/child relationship** - *a relationship between objects where one object is the parent of another object*
* **leaf/branch relationship** - *a relationship between objects where one object is a leaf and another object is a branch*
* **node** - *a point in a data structure that contains data and links to other nodes*
* **token** - *a sequence of characters that represents a single element of a programming language*
* **module** - *a self-contained unit of code that can be reused and imported into other programs*


* **definition** - *the process of giving an entity a meaning or outline*
* **initialization** - *the process of giving a variable a value for the first time*
* **declaration** - *the process of giving a name and type to a variable*
* **instantiation** - *the process of giving a variable a value for the first time*
* **implementation** - *the process of putting a plan or decision into effect*
* **assignment** - *the process of giving a variable a value*
* **enumeration** - *the process of listing items in a set*
* **partitioning** - *the process of dividing a set into subsets*
* **rendering** - *the process of displaying output to the screen*
* **aggregation** - *the process of combining multiple items into a single item*


* **compile** - *the process of converting source code into machine code*
* **build** - *the process of compiling and linking source code into an executable program*
* **run** - *the process of executing a program*
* **integrate** - *to combine different components into a single system*
* **evaluate** - *to determine the value of an expression*
* **map** - *to associate each element of one set with an element of another set*
* **pass** - *to transfer control from one part of a program to another*
* **return** - *to transfer control from a function back to the calling code*
* **invoke** - *to call a function or method*
* **expose** - *to make a variable or method accessible to other parts of a program*	
* **append** - *to add an item to the end of a list or array*
* **increment** - *to increase the value of a variable by a specified amount*
* **decrement** - *to decrease the value of a variable by a specified amount*
* **concatenate** - *to combine two or more strings into a single string*
* **embed** - *to include one object within another object*
* **parse** - *to analyze a string of characters according to the rules of a grammar*
* **query** - *to retrieve data from a database*
* **fetch** - *to retrieve data from a remote server*
* **truncate** - *to remove the decimal part of a number*
* **extend** - *to increase the size or scope of something*
* **override** - *to replace a method in a subclass with a new implementation*
* **allocate** - *to reserve memory for a variable or object*
* **reference** - *to create a reference to an object or variable*

* **orthogonal** - *at right angles; independent of each other*
* **daemons** - *background processes that run continuously and perform specific tasks without user intervention*
* **bash** - *a command-line shell and scripting language for Unix-like operating systems*
* **ubuntu** - *a popular Linux distribution*
* **unix** - *a family of multitasking, multiuser computer operating systems*
* **linux** - *a family of open-source Unix-like operating systems*
* **shell** - *a command-line interface that allows users to interact with an operating system*
* **windows powershell** - *a command-line shell and scripting language for Windows operating systems*
* **command prompt** - *a command-line interface for Windows operating systems*
* **cygwin** - *a Unix-like environment and command-line interface for Windows operating systems*
* **gnu** - *a free operating system that is compatible with Unix*
* **bash command line** - *a command-line interface for Unix-like operating systems*
* **package manager** - *a tool that automates the process of installing, upgrading, configuring, and removing software packages*
* **console** - *a text-based interface for interacting with a computer system*


* **boxing** - placing a primitive type within an object so that the value can be used as a reference
* **casting** - explicitly converting a value from one data type to another
* **derive** - creating a new class based on an existing class (inheritance); literally "to obtain something from a specified source"
* **serialize** - converting data into a format that can be stored or transmitted
* **hashing** - converting data into a fixed-size string of bytes
* **deliminate** - *to separate or distinguish between two or more items*
* **ordinal** - (of a data type) able to be counted and having a natural order
* **enumerable** - *able to be counted or listed*
* **immutable** - *unchanging over time or unable to be changed*
* **mutable** - *able to be changed or modified*
* **iterable** - *able to be iterated over or looped through*
* **iterative** - *repeating a process to achieve a desired result*
* **iterate** - *to perform a process repeatedly to achieve a desired result*
* **iterable** - able to be looped through
* **recursive** - *a function that calls itself to solve a problem*
* **deprecate** - end development on and discourage the use of software


* **pass by value** - *a method of passing arguments to a function where a copy of the original value is made*
* **pass by reference** - *a method of passing arguments to a function where a reference to the original value is made*
* **pass by anything else??** - *???*


* **reference equality** - *two references point to the same object in memory*
* **value equality** - *two values are the same, even if they are different objects in memory*
* **structural equality** - *two objects have the same structure and values*


* **subtyping** - general term for either of: extending a superclass or implementing an interface

- [ ] Parameter passing
- [ ] Identifiers

Common Lingo

Source
Target
Anchor

Function signature

More

- [ ] WebAssembly 
- [ ] Bytecode vs intermediate code
- [ ] REPL (Read-Eval-Print Loop)
- [ ] Process vs thread
- [ ] FizzBuzz?
- [ ] Hashtables
- [ ] Red-Black Tree