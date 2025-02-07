# Computer Science Notes

## Vocab

**shallow equality**: operation that checks if two references point to the same object in memory

**reference equality**: operation that checks if two references point to the same object in memory

**value equality**: operation that checks if two objects have the same value

**the heap**: memory area where objects are stored

**the stack**: Memory area where method calls and local variables are stored. Each thread has its own stack, so local variables are thread-safe.

**method area**: memory shared by all threads where class metadata, static variables, and constants are stored

**visibility**: the guarantee that changes made by one thread are visible to other threads

**atomicity**: the guarantee that an operation either completes fully or not at all and cannot be interrupted

**volatile variables**: variables that are stored in main memory and not in the thread's stack to ensure visibility (but not atomicity) across threads

**lock/monitor**: a synchronization mechanism put on a synchronized element while a thread is accessing it to ensure other threads don't interfere

**syncronized blocks/methods**: blocks of code that are executed by only one thread at a time

**final variables**: variables that cannot be reassigned

**final static variable**: a constant that is shared across all instances of a class

**final method**: a method that cannot be overridden by subclasses

**final class**: a class that cannot

**reentrant lock**: if a thread already holds a lock, it can re-claim the same synchronized block or method without being blocked

**checked exceptions**: exceptions that must be caught or declared in the method signature for exceptions that are expected

**encapsulation**: the bundling of data and methods that operate on that data into a single unit

**inheritance**: the ability of a class to inherit fields and methods from another class

**polymorphism**: the ability of an object to be used in multiple roles like a subclass being used as its superclass or an interface being used as its implementing class

**abstraction**: the process of hiding the implementation details and showing only the functionality to the user

**Lock interface**: Java interface that provides more fine-grained control over for protecting shared resources in a multithreaded environment

**Thread class**: Java class that can be extended to provide start(), run(), join(), sleep(), and interrupt() methods

**Runnable interface**: Java interface that can be implemented to provide a run() method for a thread

## Java Concepts

### Different kinds of equivalence

- **shallow equality**: `==` operator
  - Checks for reference equality (whether two references point to the same object in memory)
- **value equality**: `equals()` method
  - Checks for value equality (whether two objects have the same value)
- the `.equals()` method is inherited from the `Object` class and can be overridden in subclasses

```java
public class Person {
  private String name;

  public Person(String name) {
	this.name = name;
  }

  @Override
  public boolean equals(Object obj) {
	Person other = (Person) obj;
	return this.name.equals(other.name);
  }
}
```

- the `hashCode()` method should be overridden whenever `equals()` is overridden
- the `hashCode()` method is used by hash-based collections like `HashMap` and `HashSet`

```java
@Override
public int hashCode() {
  return this.name.hashCode();
}
```

### Java Memory Model

- **volatile variables**: variables that are stored in main memory and not in the thread's stack
  - Ensures visibility but not atomicity across threads

```java
public class SharedObject {
  private volatile int value;
}
```

- **happens-before relationshipt**: guarantees memory visibility and ordering of operations across threads
  - Acquiring a lock happens-before releasing the same lock
  - A write to a volatile variable happens-before any subsequent reads of that variable

- **synchronized blocks/methods**: blocks of code that are executed by only one thread at a time
  - Used to ensure atomicity and visibility across threads

```java
public class SharedObject {
  private int value;

  public synchronized void increment() {
	this.value++;
  }
}
```

- You can also use the `synchronized` keyword on a block of code. To do so, you must pass any non-null object to the `synchronized` keyword. A thread must acquire the lock on that object before executing the block of code.

```java
public class SharedObject {
  private int value;
  private final Object lock = new Object();

  public void increment() {
	synchronized (lock) {
	  this.value++;
	}
  }
}
```

### Final Keyword

- **final variables**: variables that cannot be reassigned
  - Must be initialized at declaration or in the constructor
- **final static variable**: a constant that is shared across all instances of a class
- **final method**: a method that cannot be overridden by subclasses
- **final class**: a class that cannot be subclassed

### Thread Joining

If threadA calls `threadB.join()`, threadA will wait for threadB to finish before continuing.

### Try-With-Resources

The try-with-resources statement is a Java feature that automatically closes resources when they are no longer needed. It is used with resources that implement the `AutoCloseable` interface.

```java
try (ResourceType resource = new ResourceType()) {
    // Use the resource
} catch (ExceptionType e) {
    // Handle exceptions
}
```

### Exceptions

- Throwable
  - Exception
    - Checked exceptions
    - Runtime exceptions
      - Unchecked exceptions
  - Error

### Polymorphism in Java

Polymorphism in Java allows objects to be treated as instances of their superclass or interface. This allows for flexibility in programming and enables code reuse.

```java
public interface Animal {
  void makeSound();
}

public class Dog implements Animal {
  @Override
  public void makeSound() {
	System.out.println("Woof");
  }
}

public class Cat implements Animal {
  @Override
  public void makeSound() {
	System.out.println("Meow");
  }
}

public class Main {
  public static void main(String[] args) {
	Animal dog = new Dog();
	Animal cat = new Cat();

	dog.makeSound(); // Output: Woof
	cat.makeSound(); // Output: Meow
  }
}
```

### Locking

- The Lock interface provides more fine-grained control over locking than synchronized blocks.
- ReentrantLock is a class that implements the Lock interface.
- ReentrantLock allows for more flexible locking mechanisms, such as timed locks, interruptible locks, and lock fairness policies.

```java
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

public class SharedObject {
  private int value;
  private Lock lock = new ReentrantLock();

  public void increment() {
	lock.lock();
	try {
	  this.value++;
	} finally {
	  lock.unlock();
	}
  }
}
```

- [x] Explain what happens with thread joining
- [x] Can an arbitrary block of code be synchronized?
- [x] Tell me more about the how the Java try-with-resources statement works
- [x] Tell me more about checked and unchecked exceptions
- [x] In practical language, tell me about Encapsulation, Inheritance, Polymorphism, and Abstraction
- [x] Are there any other ways synchronization can be used in Java?
- [x] Tell me more about Thread and Runnable in Java
- [ ] Tell me about wait(), notify(), and notifyAll()
- [ ] Tell me about collision resolution techniques like chaining and probing
- [ ] Explain the concepts of load factor and rehashing