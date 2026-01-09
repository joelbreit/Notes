# Design Patterns

- [ ] Chain of Responsibility Pattern
- [ ] Factory Pattern
- [ ] Builder Pattern
- [ ] Repository Pattern
- [ ] Decorator Pattern
- [ ] Composite Pattern
- [ ] Strategy Pattern
- [ ] Dependency Injection
- [ ] Adapter Pattern

# *Design Patterns* All Below Needs Review

## Overview

**Design patterns** are reusable solutions to commonly occurring problems in software design. They represent best practices evolved over time by experienced developers and provide a shared vocabulary for discussing architectural solutions.

## Categories of Design Patterns

Design patterns are typically organized into three main categories:

1. **Creational Patterns** - Deal with object creation mechanisms
2. **Structural Patterns** - Deal with object composition and relationships
3. **Behavioral Patterns** - Deal with communication between objects

---

## Creational Patterns

### Singleton

**Purpose**: Ensure a class has only one instance and provide a global point of access to it

**Use When**: 
- Exactly one instance of a class is needed
- Controlled access to a single instance is necessary
- Example: Database connection, logger, configuration manager

**Implementation**:
```java
public class Singleton {
    private static Singleton instance;
    
    private Singleton() {}
    
    public static Singleton getInstance() {
        if (instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}
```

### Factory Method

**Purpose**: Define an interface for creating an object, but let subclasses decide which class to instantiate

**Use When**:
- A class can't anticipate the type of objects it needs to create
- A class wants its subclasses to specify the objects it creates

### Abstract Factory

**Purpose**: Provide an interface for creating families of related or dependent objects without specifying their concrete classes

**Use When**:
- A system should be independent of how its products are created
- A system should be configured with one of multiple families of products

### Builder

**Purpose**: Separate the construction of a complex object from its representation

**Use When**:
- Creating complex objects with many optional parameters
- You want to avoid "telescoping constructors"

### Prototype

**Purpose**: Create new objects by copying an existing object (prototype)

**Use When**:
- Object creation is expensive
- You want to avoid subclasses of an object creator

---

## Structural Patterns

### Adapter

**Purpose**: Convert the interface of a class into another interface clients expect

**Use When**:
- You want to use an existing class with an incompatible interface
- You need to create a reusable class that cooperates with unrelated classes

### Bridge

**Purpose**: Decouple an abstraction from its implementation so they can vary independently

**Use When**:
- You want to avoid permanent binding between abstraction and implementation
- Both abstractions and implementations should be extensible by subclassing

### Composite

**Purpose**: Compose objects into tree structures to represent part-whole hierarchies

**Use When**:
- You want to represent part-whole hierarchies of objects
- You want clients to be able to ignore the difference between compositions of objects and individual objects

### Decorator

**Purpose**: Attach additional responsibilities to an object dynamically

**Use When**:
- You need to add responsibilities to individual objects dynamically
- Extension by subclassing is impractical

### Facade

**Purpose**: Provide a unified interface to a set of interfaces in a subsystem

**Use When**:
- You want to provide a simple interface to a complex subsystem
- There are many dependencies between clients and implementation classes

### Flyweight

**Purpose**: Use sharing to support large numbers of fine-grained objects efficiently

**Use When**:
- An application uses a large number of objects
- Storage costs are high because of the quantity of objects

### Proxy

**Purpose**: Provide a surrogate or placeholder for another object to control access to it

**Use When**:
- You need a more sophisticated reference to an object than a simple pointer
- Examples: remote proxy, virtual proxy, protection proxy

---

## Behavioral Patterns

### Chain of Responsibility

**Purpose**: Avoid coupling the sender of a request to its receiver by giving multiple objects a chance to handle the request

**Use When**:
- More than one object may handle a request
- You want to issue a request to one of several objects without specifying the receiver explicitly

### Command

**Purpose**: Encapsulate a request as an object, thereby letting you parameterize clients with different requests

**Use When**:
- You want to parameterize objects by an action to perform
- You want to queue, specify, or execute requests at different times

### Iterator

**Purpose**: Provide a way to access elements of an aggregate object sequentially without exposing its underlying representation

**Use When**:
- You want to access an aggregate's contents without exposing its internal structure
- You want to support multiple traversals of aggregate objects

### Mediator

**Purpose**: Define an object that encapsulates how a set of objects interact

**Use When**:
- A set of objects communicate in well-defined but complex ways
- Reusing an object is difficult because it refers to many other objects

### Memento

**Purpose**: Capture and externalize an object's internal state without violating encapsulation

**Use When**:
- You need to save/restore snapshots of an object's state
- A direct interface to obtaining the state would expose implementation details

### Observer

**Purpose**: Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified

**Use When**:
- An abstraction has two aspects, one dependent on the other
- A change to one object requires changing others, and you don't know how many objects need to be changed

### State

**Purpose**: Allow an object to alter its behavior when its internal state changes

**Use When**:
- An object's behavior depends on its state
- Operations have large, multipart conditional statements that depend on the object's state

### Strategy

**Purpose**: Define a family of algorithms, encapsulate each one, and make them interchangeable

**Use When**:
- Many related classes differ only in their behavior
- You need different variants of an algorithm

### Template Method

**Purpose**: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses

**Use When**:
- You want to let subclasses redefine certain steps of an algorithm without changing its structure
- Common behavior should be factored and localized in a common class

### Visitor

**Purpose**: Represent an operation to be performed on elements of an object structure

**Use When**:
- An object structure contains many classes with differing interfaces
- You want to perform operations on objects that depend on their concrete classes

---

## SOLID Principles

Design patterns often incorporate these fundamental principles:

1. **Single Responsibility Principle**: A class should have only one reason to change
2. **Open/Closed Principle**: Software entities should be open for extension but closed for modification
3. **Liskov Substitution Principle**: Derived classes must be substitutable for their base classes
4. **Interface Segregation Principle**: Many client-specific interfaces are better than one general-purpose interface
5. **Dependency Inversion Principle**: Depend on abstractions, not concretions

---

## Anti-Patterns

Common mistakes to avoid:

1. **God Object**: A class that knows too much or does too much
2. **Spaghetti Code**: Code with complex and tangled control structures
3. **Golden Hammer**: Using a familiar solution for every problem
4. **Premature Optimization**: Optimizing before you know if it's necessary
5. **Magic Numbers**: Using unnamed constants throughout code

---

## Notes

- Design patterns are guidelines, not strict rules
- Not every problem requires a design pattern
- Overusing patterns can lead to unnecessarily complex code
- Understanding the problem domain is more important than knowing patterns
- Patterns work best when combined appropriately

## Questions

- [ ] When should I use composition over inheritance?
- [ ] What's the difference between Factory Method and Abstract Factory?
- [ ] How do I know when I'm overusing design patterns?
- [ ] What are some real-world examples of each pattern?