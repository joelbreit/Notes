# JavaScript Notes

## Arrow Functions

Arrow Functions - A more concise way to write functions in JavaScript

```javascript
const add = (a, b) => a + b;
console.log(add(1, 2)); // 3
```

## Destructuring

Destructuring - A way to extract values from objects and arrays into distinct variables

```javascript
const person = { name: 'Alice', age: 30 };
const { name, age } = person;
console.log(name); // Alice
console.log(age); // 30
```

## Spread Operator

Spread Operator - A way to expand elements of an array or object

```javascript
const numbers = [1, 2, 3];
const newNumbers = [...numbers, 4, 5];
console.log(newNumbers); // [1, 2, 3, 4, 5]
```

## Rest Parameter

Rest Parameter - A way to represent an indefinite number of arguments as an array

```javascript
const sum = (...numbers) => numbers.reduce((acc, num) => acc + num, 0);
console.log(sum(1, 2, 3, 4, 5)); // 15
```

## Template Literals

Template Literals - A way to embed expressions in strings using backticks

```javascript
const name = 'Alice';
const greeting = `Hello, ${name}!`;
console.log(greeting); // Hello, Alice!
```

## Array Methods

**forEach()** method - Built-in JavaScript method that executes a provided function once for each array element

```javascript
const numbers = [1, 2, 3, 4, 5];
numbers.forEach((number) => console.log(number));
```

**map()** method - Built-in JavaScript method that creates a new array with the results of calling a provided function on every element in the array

```javascript
const numbers = [1, 2, 3, 4, 5];
const doubled = numbers.map((number) => number * 2);
console.log(doubled); // [2, 4, 6, 8, 10]
```

**filter()** method - Built-in JavaScript method that creates a new array with all elements that pass the test implemented by the provided function

```javascript
const numbers = [1, 2, 3, 4, 5];
const even = numbers.filter((number) => number % 2 === 0);
console.log(even); // [2, 4]
```

**find()** method - Built-in JavaScript method that returns the first element in an array that satisfies the provided testing function

```javascript
const numbers = [1, 2, 3, 4, 5];
const isEven = (number) => number % 2 === 0;
const firstEven = numbers.find(isEven);

console.log(firstEven); // 2
```

**reduce()** method - Built-in JavaScript method that applies a function to each element in an array to reduce the array to a single value using an initial value, an accumulator, and the current value

```javascript
const numbers = [1, 2, 3, 4, 5];
const sum = numbers.reduce((accumulator, currentValue) => accumulator + currentValue, 0);
console.log(sum); // 15
```

**some()** method - Built-in JavaScript method that tests whether at least one element in the array passes the test implemented by the provided function

```javascript
const numbers = [1, 2, 3, 4, 5];
const hasEven = numbers.some((number) => number % 2 === 0);
console.log(hasEven); // true
```
