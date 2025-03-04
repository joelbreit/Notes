# Computer Science Flashcards

Flashcards should work both ways
- Term -> Definition as well as Definition -> Term
- The definition should never use the entire term and should try to avoid using part of the term
- The definition should be concise
  - Instead of "using domain knowledge and expertise..." use "using domain knowledge"
  - Instead of "a type of machine learning where the system..." use "ML technique that"
- The definition should not be too abstract
  - Instaed of "a structured representation of the meaning of a word or phrase" use "a set of words that denote aspects of a particular type of event like a commercial transaction"
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
10. **garbage collection** - memory management via a background process that automatically finds and frees unused (unreachable) memory (Java, Python)
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

### Object-Oriented Programming

2.  **polymorphism** - the practice of allowing different types to be used in a single context like a functional allowing for multiple types of arguments or allowing subclasses to be treated as their superclass
3.  **abstraction** - generalizing and removing details to focus on the most important characteristics
4.  **encapsulation** - preventing external code from being concerned with the internal workings of an object by bundling data and methods
5.  **decoupling** - *reducing dependencies between components*
6.  **alias** - *a reference to a memory location that holds a value*
7.  **static** - *a variable or method that belongs to the class and not to instances of the class*
8.  **public** - *a variable or method that can be accessed from outside the class*
9.  **private** - *a variable or method that can only be accessed from within the class*
10. **interpolation** - *inserting a variable into a string*
11. **class** - a blueprint for creating objects that defines their properties and methods
12. **instance** - *a specific object created from a class*
13. **property** - a variable that belongs to an object
14. **method** - a function that belongs to an object and defines its behavior
15. **object** - *an instance of a class*
16. **inheritance** - *a mechanism for creating a new class that reuses the properties and methods of an existing class*
17. **subclass** - *a class that inherits from another class*
18. **superclass** - *a class that is inherited from*
19. **constructor** - *a special method that is called when an object is created*
20. **composition** - *a design technique that models a has-a relationship between objects*
21. **aggregation** - *a design technique that models a has-a relationship between objects*
22. **overloading** - *defining multiple methods with the same name but different parameters*
23. **overriding** - *replacing a method in a subclass with a new implementation*
24. **interface** - *a contract that defines the methods that a class must implement*
25. **abstract class** - *a class that cannot be instantiated and is used as a base class for other classes*
26. **singleton** - *a design pattern that restricts the instantiation of a class to one object*
27. **factory method** - *a method that creates objects without specifying the exact class of object that will be created*
28. **dependency injection** - *a design pattern that allows the removal of hard-coded dependencies and makes it possible to change them, either at run-time or compile-time*
29. **modularity** - *the degree to which a system's components may be separated and recombined*
30. **class instance** - *an object that is created from a class*

## Unorganized

37. **run-time** - *period during which a program is being executed*
38. **compile-time** - *period during which a program is being converted from human-readable code to machine code*


31. **formal variable** - *a variable that is declared in a function or method*
32. **local variable** - *a variable that is declared inside a block or function and is only accessible within that block or function*
33. **global variable** - *a variable that is declared outside of any function or block and is accessible throughout the program*
34. **class variable** - *a variable that is shared among all instances of a class*
35. **instance variable** - *a variable that is unique to each instance of a class*
36. **parameter** - *a variable that is used to pass information to a function or method*
37. **argument** - *a value that is passed to a function or method*
38. **statement** - *a complete instruction that performs an action*
39. **expression** - *a piece of code that evaluates to a single value*

1. **idempotence** - *property of an operation that can be applied multiple times without changing the result beyond the initial application*
2. **identifier** - *a name that identifies a variable, function, or other entity*
3. **assignment** - *the process of giving a variable a value*

1. **function** - *a set of instructions organized together to perform a specific task*
2. **procedure** - *a set of instructions organized together to perform a specific task*
3. **method** - *a function that belongs to an object and defines its behavior*

31. **type** - *a category of values that share common characteristics*
32. **primitive** - *a basic data type that is not composed of other data types*
33. **data structure** - *a way of organizing and storing data so that it can be accessed and modified efficiently*
34. **package** - *a collection of related classes and interfaces*
35. **import** - *a statement that allows classes and interfaces from a package to be used in a program*
36. **print** - *a function that displays output to the console*
37. **literal** - *a fixed value that is written directly in the code*
38. **reference datatype** - *a data type that stores references to objects in memory*
39. **value datatype** - *a data type that stores values directly*
40. **variable** - *a named storage location that can hold a value*
41. **identifier** - *a name that identifies a variable, function, or other entity*
42. **assignment** - *the process of giving a variable a value*
43. **idempotent** - *property of an operation that can be applied multiple times without changing the result beyond the initial application*
44. **accessor method** - *a method that retrieves the value of a property*

1. **operator** - *a symbol that performs an operation on one or more operands*
2. **operand** - *a value that is operated on by an operator*
3. **mixin** - *a class that provides a set of methods that can be added to other classes*
4. **trait** - *a set of methods that can be added to a class to provide additional functionality*
5. **interface** - *a contract that defines the methods that a class must implement*
6. **key** - *a unique identifier for a value in a data structure*
7. **domain** - *the set of possible input values for a function*
8. **library** - *a collection of precompiled routines that a program can use*
9. **embedding** - *the process of including one object within another object*
10. **embedded** - *a term used to describe an object that is included within another object*
11. **symbols** - *the basic elements of a programming language*
12. **terminals** - *the basic elements of a programming language*
13. **parent/child relationship** - *a relationship between objects where one object is the parent of another object*
14. **leaf/branch relationship** - *a relationship between objects where one object is a leaf and another object is a branch*
15. **node** - *a point in a data structure that contains data and links to other nodes*
16. **token** - *a sequence of characters that represents a single element of a programming language*
17. **module** - *a self-contained unit of code that can be reused and imported into other programs*

18. **definition** - *the process of giving an entity a meaning or outline*
19. **initialization** - *the process of giving a variable a value for the first time*
20. **declaration** - *the process of giving a name and type to a variable*
21. **instantiation** - *the process of giving a variable a value for the first time*
22. **implementation** - *the process of putting a plan or decision into effect*
23. **assignment** - *the process of giving a variable a value*
24. **enumeration** - *the process of listing items in a set*
25. **partitioning** - *the process of dividing a set into subsets*
26. **rendering** - *the process of displaying output to the screen*
27. **aggregation** - *the process of combining multiple items into a single item*

28. **compile** - *the process of converting source code into machine code*
29. **build** - *the process of compiling and linking source code into an executable program*
30. **run** - *the process of executing a program*
31. **integrate** - *to combine different components into a single system*
32. **evaluate** - *to determine the value of an expression*
33. **map** - *to associate each element of one set with an element of another set*
34. **pass** - *to transfer control from one part of a program to another*
35. **return** - *to transfer control from a function back to the calling code*
36. **invoke** - *to call a function or method*
37. **expose** - *to make a variable or method accessible to other parts of a program*	
38. **append** - *to add an item to the end of a list or array*
39. **increment** - *to increase the value of a variable by a specified amount*
40. **decrement** - *to decrease the value of a variable by a specified amount*
41. **concatenate** - *to combine two or more strings into a single string*
42. **embed** - *to include one object within another object*
43. **parse** - *to analyze a string of characters according to the rules of a grammar*
44. **query** - *to retrieve data from a database*
45. **fetch** - *to retrieve data from a remote server*
46. **truncate** - *to remove the decimal part of a number*
47. **extend** - *to increase the size or scope of something*
48. **override** - *to replace a method in a subclass with a new implementation*
49. **allocate** - *to reserve memory for a variable or object*
50. **reference** - *to create a reference to an object or variable*

51. **orthogonal** - *at right angles; independent of each other*
52. **daemons** - *background processes that run continuously and perform specific tasks without user intervention*
53. **bash** - *a command-line shell and scripting language for Unix-like operating systems*
54. **ubuntu** - *a popular Linux distribution*
55. **unix** - *a family of multitasking, multiuser computer operating systems*
56. **linux** - *a family of open-source Unix-like operating systems*
57. **shell** - *a command-line interface that allows users to interact with an operating system*
58. **windows powershell** - *a command-line shell and scripting language for Windows operating systems*
59. **command prompt** - *a command-line interface for Windows operating systems*
60. **cygwin** - *a Unix-like environment and command-line interface for Windows operating systems*
61. **gnu** - *a free operating system that is compatible with Unix*
62. **bash command line** - *a command-line interface for Unix-like operating systems*
63. **package manager** - *a tool that automates the process of installing, upgrading, configuring, and removing software packages*
64. **console** - *a text-based interface for interacting with a computer system*

65. **boxing** - placing a primitive type within an object so that the value can be used as a reference
66. **casting** - explicitly converting a value from one data type to another
67. **derive** - creating a new class based on an existing class (inheritance); literally "to obtain something from a specified source"
68. **serialize** - converting data into a format that can be stored or transmitted
69. **hashing** - converting data into a fixed-size string of bytes
70. **deliminate** - *to separate or distinguish between two or more items*
71. **ordinal** - (of a data type) able to be counted and having a natural order
72. **enumerable** - *able to be counted or listed*
73. **immutable** - *unchanging over time or unable to be changed*
74. **mutable** - *able to be changed or modified*
75. **iterable** - *able to be iterated over or looped through*
76. **iterative** - *repeating a process to achieve a desired result*
77. **iterate** - *to perform a process repeatedly to achieve a desired result*
78. **iterable** - able to be looped through
79. **recursive** - *a function that calls itself to solve a problem*
80. **deprecate** - end development on and discourage the use of software

Common Lingo

Source
Target
Anchor

Function signature

More

- [ ] WebAssembly 
- [ ] Bytecode vs intermediate code
- [ ] REPL (Read-Eval-Print Loop)