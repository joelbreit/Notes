# Go Notes

Go is a compiled language released by Google in 2012. As of 2025, it was the 13th most used language, 7th most desired, and 6th most admired language. It is statically typed, uses lightweight syntax, includes both pointers and garbage collection. Go tries to be lightweight, fast, and simple. It generally seems lighter than other garbage collected languages with simple installation, dependency management, and deployment. It is also probably the easiest language to cross-compile for multiple platforms.

## Table of Contents

## Concepts

- **Goroutines** - Go's way of handling concurrency; like threads but managed by Go instead of the OS
- **Channels** - Go's structure for communication between goroutines; like thread-safe queues
- **Duck typing** - Allowing for interfaces to be satisfied implicitly by any type that implements the required methods, without explicit declaration

## Notes

- Go is great, maybe the best, for Cross-platform compilation
- Go is compiled directly to machine code, making it very fast
- Strong, static type system with type inference
- Simple syntax with only 25 keywords
- Block scoped
- Unused imports and variables cause compilation errors
- `gofmt` automatically formats code consistently

| Type       | Frequency of Use |
| ---------- | ---------------- |
| Pointers   | Commonly         |
| Structs    | Very Frequently  |
| Interfaces | Frequently       |
| Arrays     | Occasionally     |
| Slices     | Very Frequently  |
| Maps       | Very Frequently  |

- The entry point of a Go program is the `main` function in the `main` package
- It is common in Go to include packages by just including their source code in the same directory
- Go uses both pointers and garbage collection for memory management
- Go doesn't have classes, but has structs with methods


### Libraries

Standard library packages are imported with their package names:
```go
import (
    "fmt"      // Formatted I/O
    "net/http" // HTTP client and server
    "encoding/json" // JSON encoding/decoding
    "time"     // Time and duration
    "os"       // Operating system interface
    "io"       // I/O primitives
    "strings"  // String manipulation
    "strconv"  // String conversions
)
```

## Syntax

- Single-line comments: `//`
- Multi-line comments: `/* */`
- Single quotes for runes (characters): `'a'`
- Double quotes for strings: `"Hello"`
- Backticks for raw strings: `` `Hello\nWorld` `` (no escape sequences)

Casting:
- Type conversion: `int(variable)`
- Type assertion: `variable.(type)`

Reserved words:

```go
break case chan const continue default defer else fallthrough for func go goto if import interface map package range return select struct switch type var
```

## Data Types

Primitive data types in Go:

- `int` - integer (platform-specific size)
  - Also `int8`, `int16`, `int32`, `int64` for specific sizes
  - Unsigned versions: `uint`, `uint8`, `uint16`, `uint32`, `uint64`, `uintptr`
- `float32`, `float64` - floating-point numbers
- `string` - text (UTF-8 encoded)
- `rune` - alias for `int32`, represents a Unicode code point
- `byte` - alias for `uint8`
- `bool` - true or false

Zero values:
- `0` for numeric types
- `false` for boolean
- `""` for strings
- `nil` for pointers, functions, interfaces, slices, channels, and maps

Pointers:
```go
var ptr *int        // Pointer declaration
num := 42
ptr = &num          // Get address
value := *ptr       // Dereference
```

## Modifiers

- `const` - compile-time constant
- `var` - variable declaration
- `type` - type definition

## Control Flow

```go
// If statement
if condition {
    // code
} else if otherCondition {
    // code
} else {
    // code
}

// If with initialization
if x := getValue(); x > 0 {
    // x is scoped to this if block
}

// Switch statement
switch value {
case 1:
    // code
case 2, 3:
    // multiple values
default:
    // default case
}

// Type switch
switch v := interface{}(value).(type) {
case int:
    // v is int
case string:
    // v is string
}

// For loop (only loop construct)
for i := 0; i < 10; i++ {
    // code
}

// While-style loop
for condition {
    // code
}

// Infinite loop
for {
    // code
}

// Range loop
for index, value := range slice {
    // code
}

// Range with blank identifier
for _, value := range slice {
    // code
}
```

## Data Structures

### Arrays and Slices

Arrays (fixed size):
```go
var arr [5]int
arr2 := [3]int{1, 2, 3}
arr3 := [...]int{1, 2, 3} // Size inferred
```

Slices (dynamic):

- **Slice** - Go's version of a dynamic array, which is a reference to an underlying array
  - Allows to accessing the capacity of the underlying array

```go
var slice []int
slice = append(slice, 1, 2, 3)
slice2 := []int{1, 2, 3}
slice3 := make([]int, 5)      // length 5
slice4 := make([]int, 5, 10)  // length 5, capacity 10
```

### Maps

- **Map** - Go's built-in associative data type (hash table)

```go
var m map[string]int
m = make(map[string]int)
m["key"] = 42

// Map literal
m2 := map[string]int{
    "alice": 30,
    "bob":   25,
}

// Check if key exists
value, ok := m["key"]
if ok {
    // key exists
}

// Delete key
delete(m, "key")
```

### Structs

```go
type Person struct {
    Name string
    Age  int
}

// Struct literal
p1 := Person{Name: "Alice", Age: 30}
p2 := Person{"Bob", 25}

// Anonymous struct
p3 := struct {
    Name string
    Age  int
}{
    Name: "Charlie",
    Age:  35,
}
```

## Functions

Function definition:
```go
func Add(a, b int) int {
    return a + b
}

// Multiple return values
func Divide(a, b float64) (float64, error) {
    if b == 0 {
        return 0, errors.New("division by zero")
    }
    return a / b, nil
}

// Named return values
func Split(sum int) (x, y int) {
    x = sum * 4 / 9
    y = sum - x
    return // naked return
}

// Variadic function
func Sum(nums ...int) int {
    total := 0
    for _, num := range nums {
        total += num
    }
    return total
}

// Function as type
type Calculator func(int, int) int

// Higher-order function
func Apply(fn Calculator, a, b int) int {
    return fn(a, b)
}

// Closure
func Counter() func() int {
    count := 0
    return func() int {
        count++
        return count
    }
}
```

## Methods and Interfaces

Methods on structs:
```go
type Rectangle struct {
    Width, Height float64
}

// Value receiver
func (r Rectangle) Area() float64 {
    return r.Width * r.Height
}

// Pointer receiver
func (r *Rectangle) Scale(factor float64) {
    r.Width *= factor
    r.Height *= factor
}
```

Interfaces:
```go
type Shape interface {
    Area() float64
    Perimeter() float64
}

// Rectangle satisfies Shape if it implements both methods
func (r Rectangle) Perimeter() float64 {
    return 2 * (r.Width + r.Height)
}

// Empty interface
var anything interface{}
anything = 42
anything = "hello"
```

## Error Handling

```go
// Error type
type error interface {
    Error() string
}

// Creating errors
import "errors"
err := errors.New("something went wrong")

// Custom error
type MyError struct {
    Code    int
    Message string
}

func (e MyError) Error() string {
    return fmt.Sprintf("Error %d: %s", e.Code, e.Message)
}

// Error handling pattern
if err != nil {
    return err
}
```

## Concurrency

Goroutines:
```go
// Start a goroutine
go someFunction()

// Anonymous goroutine
go func() {
    fmt.Println("Hello from goroutine")
}()
```

Channels:
```go
// Create channel
ch := make(chan int)
ch2 := make(chan int, 10) // Buffered channel

// Send and receive
ch <- 42        // Send
value := <-ch   // Receive

// Close channel
close(ch)

// Check if channel is closed
value, ok := <-ch
if !ok {
    // Channel is closed
}

// Range over channel
for value := range ch {
    // Process value
}

// Select statement
select {
case msg1 := <-ch1:
    // Handle msg1
case msg2 := <-ch2:
    // Handle msg2
case <-time.After(1 * time.Second):
    // Timeout
default:
    // Non-blocking
}
```

## Common Tasks

Basic I/O:
```go
package main

import "fmt"

func main() {
    fmt.Println("Hello, World!")
    
    var name string
    fmt.Print("Enter name: ")
    fmt.Scanln(&name)
    fmt.Printf("Hello, %s!\n", name)
}
```

String operations:
```go
import "strings"

str := "Hello, World!"
upper := strings.ToUpper(str)
contains := strings.Contains(str, "World")
split := strings.Split(str, ", ")
```

JSON handling:
```go
import "encoding/json"

type Person struct {
    Name string `json:"name"`
    Age  int    `json:"age"`
}

// Marshal to JSON
p := Person{Name: "Alice", Age: 30}
data, err := json.Marshal(p)

// Unmarshal from JSON
var p2 Person
err = json.Unmarshal(data, &p2)
```

File operations:
```go
import (
    "io/ioutil"
    "os"
)

// Read file
data, err := ioutil.ReadFile("file.txt")

// Write file
err = ioutil.WriteFile("file.txt", []byte("content"), 0644)

// Create file
file, err := os.Create("file.txt")
defer file.Close()
```

HTTP server:
```go
import (
    "fmt"
    "net/http"
)

func handler(w http.ResponseWriter, r *http.Request) {
    fmt.Fprintf(w, "Hello, World!")
}

func main() {
    http.HandleFunc("/", handler)
    http.ListenAndServe(":8080", nil)
}
```

## Package Management

Module initialization:
```bash
go mod init module-name
```

Adding dependencies:
```bash
go get github.com/user/package
```

Go commands:
```bash
go run main.go        # Run program
go build             # Compile
go install           # Install binary
go test              # Run tests
go fmt               # Format code
go vet               # Check for issues
go mod tidy          # Clean up dependencies
```

## Naming Conventions

- **PascalCase** for exported (public) functions, types, and variables
- **camelCase** for unexported (private) functions and variables
- **MixedCaps** rather than underscores
- **Interface names** often end with `-er` (e.g., `Reader`, `Writer`)
- **Package names** are lowercase, single words when possible
- **Constants** use PascalCase or camelCase, not SCREAMING_SNAKE_CASE

## Thoughts

### Positives

- Simple to get set up and run
- Very easy cross-platform compilation
- Garbage collection
- Strong typing with type inference

### Negatives

- Still uses pointers even without the benefits of manual memory management
- Verbose (annoying) error handling
- Clumsy OOP support

## Questions

- [ ] What are some common Go design patterns?
- [ ] How does Go handle package visibility?
- [ ] What's the difference between `new` and `make`?
- [ ] Slices (but more)
- [ ] Receivers