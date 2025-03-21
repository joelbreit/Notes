# C++ Syntax Flashcards

declare a variable with automatic type inference

`auto num = 5;`

create a smart pointer that automatically frees memory

`std::unique_ptr<int> ptr = std::make_unique<int>(42);`

iterate through a container using a range-based for loop

```cpp
for (const auto& element : container) {
    // process element
}
```

create a lambda function that captures variables by reference

```cpp
auto multiply = [&factor](int x) {
    return x * factor;
};
```

define a class with default constructor and destructor

```cpp
class MyClass {
public:
    MyClass() = default;
    ~MyClass() = default;
};
```

prevent a class from being copied

```cpp
class MyClass {
public:
    MyClass(const MyClass&) = delete;
    MyClass& operator=(const MyClass&) = delete;
};
```

implement a move constructor

```cpp
MyClass(MyClass&& other) noexcept {
    data = other.data;
    other.data = nullptr;
}
```

create a template function that works with any numeric type

```cpp
template<typename T, 
         typename = std::enable_if_t<std::is_arithmetic_v<T>>>
T square(T value) {
    return value * value;
}
```

define a function that throws an exception

```cpp
void divide(int a, int b) {
    if (b == 0) {
        throw std::invalid_argument("Division by zero");
    }
    return a / b;
}
```

create a container of unique elements

`std::set<int> uniqueNumbers;`

create a thread that executes a function

```cpp
std::thread t([]() {
    std::cout << "Running in thread\n";
});
t.join();
```

define a virtual function that must be implemented by derived classes

`virtual void process() = 0;`

check if a value exists in a vector

```cpp
if (std::find(vec.begin(), vec.end(), value) != vec.end()) {
    // value exists in vector
}
```

create a mutex and lock it for thread safety

```cpp
std::mutex mtx;
std::lock_guard<std::mutex> lock(mtx);
// protected code
```

create a compile-time constant

`constexpr int MAX_SIZE = 100;`

cast between pointer types with runtime type checking

`DerivedClass* derived = dynamic_cast<DerivedClass*>(basePtr);`

define a function with default parameters

`void setValues(int a = 0, double b = 1.0);`

convert a string to an integer with error handling

```cpp
try {
    int num = std::stoi(str);
} catch (const std::invalid_argument& e) {
    // handle invalid input
} catch (const std::out_of_range& e) {
    // handle out of range
}
```

create a tuple with multiple types

`std::tuple<int, std::string, double> data(42, "text", 3.14);`

define a function that can take variable number of arguments

```cpp
template<typename... Args>
void print(Args... args) {
    (std::cout << ... << args) << '\n';
}
```

create a container that maps keys to values

`std::unordered_map<std::string, int> nameToAge;`

call a static method of a class

`ClassName::staticMethod();`

define a class constant that can be used without instantiation

`static constexpr double PI = 3.14159265359;`

define a struct with public member variables

```cpp
struct Point {
    int x;
    int y;
};
```

declare a reference to a constant value

`const int& ref = value;`

create a function pointer

`void (*funcPtr)(int, double) = &myFunction;`

initialize a container with values

```cpp
std::vector<int> numbers = {1, 2, 3, 4, 5};
```

create an enum with specified underlying type

```cpp
enum class Color : uint8_t {
    Red = 0,
    Green = 1,
    Blue = 2
};
```

check if a condition is true at compile time

```cpp
if constexpr (std::is_same_v<T, int>) {
    // int-specific code
}
```

sort a vector in descending order

```cpp
std::sort(vec.begin(), vec.end(), 
       [](int a, int b) { return a > b; });
```

declare a function that won't modify the object

`int getValue() const;`

- [x] const references
- [ ] Lambda..?