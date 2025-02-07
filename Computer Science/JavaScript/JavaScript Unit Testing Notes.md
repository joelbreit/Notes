# JavaScript Unit Testing Notes

## Definitions

**Test Runner** - A tool that executes tests and provides feedback on the results
- Automatically detects testing code
- Jest is a popular test runner for JavaScript

**Assertion Library** - A tool that defines the syntax for writing tests
- Defines the expected outcomes of tests and reports whether the tests pass or fail
- Jest includes an assertion library

## Vitest

Vitest is a test runner that uses Jest as its assertion library

Install Vitest:
`npm install --save-dev vitest`
- `--save-dev` flag saves the package as a development dependency. This means the package is not needed for the production version of the application

Add a test script to the `package.json` file:
```json
"scripts": {
  "test": "vitest --global"
}
```
- The `--global` flag allows Vitest to use functions like `describe` and `it` without importing them

## Writing Tests

**`test()`** / **`it()`** functions - Used to define a test case
- Takes a description of the test case and a callback function that contains the test logic
- The callback function should contain one or more **assertions**

**`expect()`** function - Used to define an assertion
- Takes a value and returns an object with methods to define the expected outcome of the test
- Methods like `toBe()`, `toEqual()`, `toBeTruthy()`, `toBeFalsy()`, `toBeNull()`, `toBeUndefined()`, `toContain()`, `toHaveLength()`, etc., can be used to define the expected outcome

```javascript
test('adds 1 + 2 to equal 3', () => {
  expect(1 + 2).toBe(3);
});
```

Test that a function throws an error:
```javascript
it('throws an error', () => {
  expect(() => { // wrap the error-throwing code in a function
	throw new Error('Test error');
  }).toThrow('Test error');
});
```

**not()** method - Used to negate an assertion
```javascript
test('adds 1 + 2 to not equal 4', () => {
  expect(1 + 2).not.toBe(4);
});
```

## Notes

Node.js is a JavaScript runtime environment that allows developers to run JavaScript as a standalone application outside of a web browser

ES6 modules are used to import and export functions, variables, and classes between files. The `import` and `export` keywords are used to define the module structure. With ES6 modules, you can create reusable code and organize your project into separate files